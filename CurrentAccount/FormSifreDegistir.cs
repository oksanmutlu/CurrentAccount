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
    public partial class FormSifreDegistir : Form
    {
        
       
        Employee _employee;

        public FormSifreDegistir()
        {
            InitializeComponent();
            _employee = new Employee();
        }      

        private void BtnSifreyiDegistir_Click(object sender, EventArgs e)
        {
           var sifre = Singleton.Context.Employees.Select(em => em.Password);
            if (txtEskiSifre.Text==sifre.ToString())
            {
                if (txtYeniSifre.Text==txtYeniSifreTekrar.Text)
                {
                    _employee.Password = txtYeniSifre.Text;
                    MessageBox.Show("Şifreniz Değişti.");
                }
                else
                {
                    MessageBox.Show("Yeni şifre ile yeni şifrenin tekrarı uyuşmuyor!");
                }
            }
            else
            {
                MessageBox.Show("Eski şifreyi yanlış girdiniz!");
            }
        }

    }
}
