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
    public partial class FormMusteriEkle : Form
    {
        public FormMusteriEkle()
        {
            InitializeComponent();
            txtTelefon.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            Customer customers = new Customer()
            {
                FirstName = txtAd.Text.Trim(),
                LastName = txtSoyad.Text.Trim(),
                Phone=txtTelefon.Text.Trim(),
                Email=txtEmail.Text.Trim(),
                Adress=txtAdres.Text.Trim()
            };

            Singleton.Context.Customers.Add(customers);
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Müşteri Eklendi");            
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
