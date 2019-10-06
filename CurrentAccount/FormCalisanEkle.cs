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
    public partial class FormCalisanEkle : Form
    {
    
        public FormCalisanEkle()
        {
            InitializeComponent();
            txtTelefon.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol()==false)
            {
                return;
            }
            Employee employee = new Employee()
            {
                FirstName = txtAd.Text.Trim(),
                LastName = txtSoyad.Text.Trim(),
                Phone = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                BirthDate=dtpDogumTarihi.Value,
                Password=txtSifre.Text,
                Statu=Convert.ToBoolean(cmbStatu.SelectedIndex),
                Adress = txtAdres.Text.Trim()
            };

            Singleton.Context.Employees.Add(employee);
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Çalışan Eklendi");
        }

        private bool VeriGirisKontrol()
        {           
            string kontrol = string.IsNullOrWhiteSpace(txtAd.Text) ? "Ad \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtSoyad.Text) ? "Soyad \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtTelefon.Text) ? "Telefon \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtEmail.Text) ? "Email \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtSifre.Text) ? "Sifre \n" : "";
            kontrol += string.IsNullOrWhiteSpace(cmbStatu.Text) ? "Statu \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtAdres.Text) ? "Adres \n" : "";
            if (kontrol=="")
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
