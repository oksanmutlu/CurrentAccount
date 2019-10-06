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
    public partial class FormTedarikciEkle : Form
    {
        public FormTedarikciEkle()
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
            Supplier suppliers = new Supplier()
            {                
                CompanyName = txtSirketAdi.Text.Trim(),
                Phone = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Adress = txtAdres.Text.Trim()
            };
            Singleton.Context.Suppliers.Add(suppliers);
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Tedarikçi Eklendi");
        }
        private bool VeriGirisKontrol()
        {
            string kontrol = string.IsNullOrWhiteSpace(txtSirketAdi.Text) ? "Şirket Adı \n" : "";
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
