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
    public partial class FormCalisanGuncelle : Form
    {
        private Employee _employee;

        public FormCalisanGuncelle(Employee employee, CurrentAccountContext db)
        {
            InitializeComponent();
            _employee = employee;
            txtTelefon.KeyPress += WinFormHelpers.TamSayiyaIzinVer;
        }


        private void FormCalisanGuncelle_Load(object sender, EventArgs e)
        {
            txtAd.Text = _employee.FirstName;
            txtSoyad.Text = _employee.LastName;
            txtTelefon.Text = _employee.Phone;
            txtEmail.Text = _employee.Email;
            dtpDogumTarihi.Value = Convert.ToDateTime(_employee.BirthDate);
            txtSifre.Text = _employee.Password;
            cmbStatu.SelectedIndex = Convert.ToInt16(_employee.Statu);
            txtAdres.Text = _employee.Adress;
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            _employee.FirstName = txtAd.Text.Trim();
            _employee.LastName = txtSoyad.Text.Trim();
            _employee.Phone = txtTelefon.Text.Trim();
            _employee.Email = txtEmail.Text.Trim();
            _employee.BirthDate = dtpDogumTarihi.Value;
            _employee.Password = txtSifre.Text;
            _employee.Statu = Convert.ToBoolean(cmbStatu.SelectedIndex);
            _employee.Adress = txtAdres.Text.Trim();
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Çalışan Güncellendi");
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
