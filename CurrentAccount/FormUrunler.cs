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
    public partial class FormUrunler : Form
    {
        public FormUrunler()
        {
            InitializeComponent();
        }

        private void FormUrunler_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FormUrunEkle frm = new FormUrunEkle();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lsvUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvUrunler.SelectedItems[0];
            Product product = (Product)item.Tag;
            FormUrunGuncelle frm = new FormUrunGuncelle(product, Singleton.Context);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
           
            if (lsvUrunler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir ürün seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvUrunler.SelectedItems[0];
            Product product = (Product)item.Tag;
            

            int satisSayisi = UrunlerinSatisi(Convert.ToInt32(item.Text));
            if (satisSayisi < 1)
            {
                Singleton.Context.Products.Remove(product);
                WinFormHelpers.KontrolluKaydet(Singleton.Context,"Ürün silindi");
                ListeGuncelle();
            }
            else
            {
                if (Kullanici.statu == true)
                {
                    DialogResult secenek = MessageBox.Show("Bu üründe " + satisSayisi + " farklı satış var. Ürünle bağlantılı satışlarda silinecek. Devam etmek istiyor musuz?", "Bilgilendirme Penceresi", MessageBoxButtons.OKCancel);
                    if (secenek == DialogResult.OK)
                    {
                        SatisSil(Convert.ToInt32(item.Text));
                        Singleton.Context.Products.Remove(product);
                        WinFormHelpers.KontrolluKaydet(Singleton.Context,"Ürün silindi");
                        ListeGuncelle();
                    }
                }
                else
                {
                    MessageBox.Show("Bu üründe " + satisSayisi + " farklı satış var. Ürünle bağlantılı satışlarda silinir. Ürünü olan tedarikçileri SİLME YETKİNİZ YOK", "Bilgilendirme Penceresi");
                }
            }
        }
        private void SatisSil(int urunID)
        {
            IEnumerable<Sale> urununSatislari = Singleton.Context.Sales
                .Where(s => s.ProductID.Equals(urunID)).ToList();
            Singleton.Context.Sales.RemoveRange(urununSatislari);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Ürünün satışları silindi");
            ListeGuncelle();
        }
        private int UrunlerinSatisi(int urunID)
        {
            int satisSayisi = Singleton.Context.Sales
                 .Where(s => s.ProductID.Equals(urunID))
                 .Select(s => s.ID).Count();
            return satisSayisi;
        }

        private void ListeGuncelle()
        {
           
            lsvUrunler.Items.Clear();
            var product = Singleton.Context.Products.ToList();
            foreach (var item in product)
            {  
                string[] degerler = new string[8]
                               {
                    item.ID.ToString(),
                    item.ProductName,
                    item.CategoryID.ToString()== null ? "Boş bırakılmış" :item.Category.CategoryName,
                    item.PurchasePrice.ToString(),
                    item.SalePrice.ToString(),
                    item.Stok.ToString(),
                    item.SupplierID.ToString()== null ? "Boş bırakılmış" :item.Supplier.CompanyName,
                    item.Description
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvUrunler.Items.Add(viewItem);
            }
        }
        public void ListeGuncelle(object sender, EventArgs e)
        {
            ListeGuncelle();
        }

    }
}
