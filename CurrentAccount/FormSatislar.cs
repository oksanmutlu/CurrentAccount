using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAccount
{
    public partial class FormSatislar : Form
    {
        public FormSatislar()
        {
            InitializeComponent();
        }
        private void CmbMusteri_TextUpdate(object sender, EventArgs e)
        {
            cmbMusteri.DroppedDown = false;
            cmbMusteri.DataSource = null;

            string girilenDegeriSaklayan = cmbMusteri.Text;

            var custormers = Singleton.Context.Customers.Where(c =>(c.FirstName+" "+c.LastName).Contains(cmbMusteri.Text)).ToList();
            cmbMusteri.DisplayMember = "FullName";
            cmbMusteri.ValueMember = "ID";
            cmbMusteri.DataSource = custormers;
            cmbMusteri.SelectedIndex = -1;
            cmbMusteri.Text = girilenDegeriSaklayan;
            cmbMusteri.Select(cmbMusteri.Text.Length, 0);

            cmbMusteri.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void CmbUrun_TextUpdate(object sender, EventArgs e)
        {
            cmbUrun.DroppedDown = false;
            cmbUrun.DataSource = null;


            string girilenDegeriSaklayan = cmbUrun.Text;

            //if (cmbUrun.Text.Length < 2)
            //{
            //    cmbUrun.Select(cmbUrun.Text.Length, 0);
            //    return;
            //}


            var degerler = Singleton.Context.Set<Product>().Where(x => x.ProductName.Contains(cmbUrun.Text)).ToList();
            cmbUrun.DisplayMember = "ProductName";
            cmbUrun.ValueMember = "ID";
            cmbUrun.DataSource = degerler;
            cmbUrun.SelectedIndex = -1;
            cmbUrun.Text = girilenDegeriSaklayan;
            cmbUrun.Select(cmbUrun.Text.Length, 0);

            cmbUrun.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void NudAdet_ValueChanged(object sender, EventArgs e)
        {
            if (cmbUrun.SelectedItem == null)
            {
                return;
            }
            var urun = (Product)cmbUrun.SelectedItem;
            decimal toplam = urun.SalePrice * nudAdet.Value * ((decimal)1 - (nudIndirim.Value / 100));
            txtToplam.Text = toplam.ToString();//İndirimli fiyat
        }

        private void CmbUrun_SelectedIndexChanged(object sender, EventArgs e)
        {
            Temizle();
        }

        private void BtnSat_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }

            Sale sale = new Sale()
            {
                Product = (Product)cmbUrun.SelectedItem,
                Quantity = Convert.ToInt32(nudAdet.Value),
                Customer = (Customer)cmbMusteri.SelectedItem,
                SellDate = DateTime.Now,
                Discount = Convert.ToByte(nudIndirim.Value),
                DiscountedPrice = Convert.ToDecimal(txtToplam.Text),
                EmployeeID = Kullanici.id
            };

            if (sale.Product.Stok > nudAdet.Value)
            {
                sale.Product.Stok -= (int)nudAdet.Value; //Stoktan düşüyor.
                Singleton.Context.Sales.Add(sale);
                WinFormHelpers.KontrolluKaydet(Singleton.Context,"Satış gerçekleşti");
                ListeGuncelle();
                Temizle();
                cmbMusteri.SelectedIndex = -1;
                cmbUrun.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Satış gerçekleşemez! Çünkü stokta " + sale.Product.Stok + " adet ürün bulunmaktadır.");
            }
        }
        private void Temizle()
        {
            nudAdet.Value = 0;
            nudIndirim.Value = 0;
            txtToplam.Text = "0";
        }       
        private void ListeGuncelle()
        {
            lsvSatislar.Items.Clear();
            foreach (var item in SatisGetir())
            {
                string[] degerler = new string[8]
                {
                    item.ID.ToString(),
                    item.ProductID.ToString()== null ? "Boş bırakılmış" :item.Product.ProductName,
                    item.Quantity.ToString(),
                    item.CustomerID.ToString()== null ? "Boş bırakılmış" :item.Customer.FirstName+" "+ item.Customer.LastName,
                    item.SellDate.ToString(),
                    item.Discount.ToString(),
                    item.DiscountedPrice.ToString(),
                    item.EmployeeID.ToString()== null ? "Boş bırakılmış" :item.Employee.FirstName+" "+ item.Employee.LastName
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvSatislar.Items.Add(viewItem);
            }
        }
        private IEnumerable<Sale> SatisGetir()
        {
            if (Kullanici.statu == true)
            {
                return Singleton.Context.Sales.OrderByDescending(s => s.SellDate).ToList();
            }
            else
            {
                return Singleton.Context.Sales
                    .Where(s => s.EmployeeID.Equals(Kullanici.id)).OrderByDescending(s => s.SellDate).ToList();
            }
        }
        private void BtnSatisIptal_Click(object sender, EventArgs e)
        {
            if (lsvSatislar.SelectedIndices.Count == 0)
            {
                MessageBox.Show("İptal işlemi öncesinde bir satış seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvSatislar.SelectedItems[0];
            Sale sale = (Sale)item.Tag;
            sale.Product.Stok += sale.Quantity;//Ürün satışı iptal olduğundan stoğa geri koyduk.         
            Singleton.Context.Sales.Remove(sale);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Satış iptali gerçekleşti");
            lsvSatislar.SelectedItems[0].Remove();
            ListeGuncelle();
        }     
        private void FormSatislar_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private bool VeriGirisKontrol()
        {
            string kontrol = string.IsNullOrWhiteSpace(cmbMusteri.Text) ? "Müşteri Adı\n" : "";
            kontrol += string.IsNullOrWhiteSpace(cmbUrun.Text) ? "Ürün Adı\n" : "";
            kontrol += nudAdet.Value==0 ? "Adet 0 olamaz yani\n" : "";
            if (kontrol == "")
            {
                return true;
            }
            else
            {
                kontrol += "boş bırakılamaz!";
                MessageBox.Show(kontrol);
                return false;
            }
        }
    }
}
