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
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
            txtAlisFiyati.KeyPress += WinFormHelpers.OndalikliSayiyaIzinVer;
            txtSatisFiyati.KeyPress += WinFormHelpers.OndalikliSayiyaIzinVer;
            txtStok.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }
        private void FormUrunEkle_Load(object sender, EventArgs e)
        {
            var kategoriler = Singleton.Context.Categories.ToList();
            cmbKategoriler.DisplayMember= "CategoryName";
            cmbKategoriler.ValueMember = "ID";
            cmbKategoriler.DataSource = kategoriler;
            cmbKategoriler.SelectedIndex = -1;
            
            var tedarikciler = Singleton.Context.Suppliers.ToList();
            cmbTedarikciler.DisplayMember = "CompanyName";
            cmbTedarikciler.ValueMember = "ID";
            cmbTedarikciler.DataSource = tedarikciler;
            cmbTedarikciler.SelectedIndex = -1;
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            Product products = new Product()
            {
                ProductName = txtUrunAdi.Text.Trim(),
                Category =(Category)cmbKategoriler.SelectedItem,
                Supplier =(Supplier)cmbTedarikciler.SelectedItem,
                PurchasePrice = Convert.ToInt32(txtAlisFiyati.Text),
                SalePrice = Convert.ToInt32(txtSatisFiyati.Text),
                Stok = Convert.ToInt32(txtStok.Text),
                Description = txtAciklama.Text.Trim()
            };

            Singleton.Context.Products.Add(products);
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Ürün Eklendi");
        }
        public bool VeriGirisKontrol()
        {
            string kontrol = string.IsNullOrWhiteSpace(txtUrunAdi.Text) ? "Ürün Adı \n" : "";
            kontrol += string.IsNullOrWhiteSpace(cmbKategoriler.Text) ? "Kategori \n" : "";
            kontrol += string.IsNullOrWhiteSpace(cmbTedarikciler.Text) ? "Tedarikçi \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtAlisFiyati.Text) ? "Alış Fiyatı \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtSatisFiyati.Text) ? "Satış Fiyatı \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtStok.Text) ? "Stok \n" : "";
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
