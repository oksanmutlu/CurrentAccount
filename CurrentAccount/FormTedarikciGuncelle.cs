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
    public partial class FormTedarikciGuncelle : Form
    {
        private Supplier _supplier;

        public FormTedarikciGuncelle(Supplier supplier, CurrentAccountContext db)
        {
            InitializeComponent();
            _supplier = supplier;
            txtTelefon.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }
        private void FormTedarikciGuncelle_Load(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            txtSirketAdi.Text = _supplier.CompanyName;            
            txtTelefon.Text = _supplier.Phone;
            txtEmail.Text = _supplier.Email;
            txtAdres.Text = _supplier.Adress;
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            _supplier.CompanyName = txtSirketAdi.Text.Trim();
            _supplier.Phone = txtTelefon.Text.Trim();
            _supplier.Email = txtEmail.Text.Trim();
            _supplier.Adress = txtAdres.Text.Trim();
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Tedarikçi Güncellendi");
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
