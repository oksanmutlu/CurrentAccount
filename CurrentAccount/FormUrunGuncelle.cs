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
    public partial class FormUrunGuncelle : Form
    {
        private Product _product;

        public FormUrunGuncelle(Product product, CurrentAccountContext db)
        {
            InitializeComponent();
            _product = product;
            txtAlisFiyati.KeyPress += WinFormHelpers.OndalikliSayiyaIzinVer;
            txtSatisFiyati.KeyPress += WinFormHelpers.OndalikliSayiyaIzinVer;
            txtStok.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }
        private void FormUrunGuncelle_Load(object sender, EventArgs e)
        {
            var kategoriler = Singleton.Context.Categories.ToList();
            cmbKategoriler.DisplayMember = "CategoryName";
            cmbKategoriler.ValueMember = "ID";
            cmbKategoriler.DataSource = kategoriler;
            cmbKategoriler.SelectedIndex = -1;

            var tedarikciler = Singleton.Context.Suppliers.ToList();
            cmbTedarikciler.DisplayMember = "CompanyName";
            cmbTedarikciler.ValueMember = "ID";
            cmbTedarikciler.DataSource = tedarikciler;
            cmbTedarikciler.SelectedIndex = -1;

            txtUrunID.Text = _product.ID.ToString();
            cmbKategoriler.SelectedValue = _product.CategoryID;
            txtUrunAdi.Text = _product.ProductName;
            cmbTedarikciler.SelectedValue = _product.SupplierID;
            txtAlisFiyati.Text = _product.PurchasePrice.ToString();
            txtSatisFiyati.Text = _product.SalePrice.ToString();
            txtStok.Text = _product.Stok.ToString();
            txtAciklama.Text = _product.Description;
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            _product.Category = (Category)cmbKategoriler.SelectedItem;
            _product.ProductName = txtUrunAdi.Text.Trim();
            _product.Supplier = (Supplier)cmbTedarikciler.SelectedItem;
            _product.PurchasePrice =decimal.Parse(txtAlisFiyati.Text);
            _product.SalePrice = decimal.Parse(txtSatisFiyati.Text);
            _product.Stok = int.Parse(txtStok.Text);
            _product.Description = txtAciklama.Text.Trim();
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Ürün Güncellendi");
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
