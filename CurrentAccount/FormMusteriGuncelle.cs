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
    public partial class FormMusteriGuncelle : Form
    {
        private Customer _customer;
      

        public FormMusteriGuncelle(Customer customer, CurrentAccountContext db)
        {
            InitializeComponent();
            _customer = customer;
            txtTelefon.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }
      

        private void FormMusteriGuncelle_Load(object sender, EventArgs e)
        {
            txtAd.Text = _customer.FirstName;
            txtSoyad.Text = _customer.LastName;
            txtTelefon.Text = _customer.Phone;
            txtEmail.Text = _customer.Email;
            txtAdres.Text = _customer.Adress;
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            _customer.FirstName = txtAd.Text.Trim();
            _customer.LastName = txtSoyad.Text.Trim();
            _customer.Phone = txtTelefon.Text.Trim();
            _customer.Email = txtEmail.Text.Trim();
            _customer.Adress = txtAdres.Text.Trim();
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Müşteri Güncellendi");
        }
        private bool VeriGirisKontrol()
        {
            string kontrol = string.IsNullOrWhiteSpace(txtAd.Text) ? "Ad \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtSoyad.Text) ? "Soyad \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtTelefon.Text) ? "Telefon \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtEmail.Text) ? "Email \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtAdres.Text) ? "Adres \n" : "";
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
