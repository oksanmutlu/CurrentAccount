using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAccount
{
    public partial class FormGiris : Form
    {        
        public FormGiris()
        {
            InitializeComponent();           
        }
        private void btnGiris_Click(object sender, EventArgs e)
        {
            var employee = Singleton.Context.Employees.
                           Where(em => em.Email.Equals(txtEmail.Text.ToString()) && em.Password.Equals(txtSifre.Text.ToString()))
                           .FirstOrDefault();
            if (employee != null)
            {
                FormAna frm = new FormAna();
                Kullanici.adSoyad = employee.FirstName + " " + employee.LastName;
                Kullanici.statu = employee.Statu;
                Kullanici.id = employee.ID;
                frm.Show();
                this.Hide();
            }
            else
            {
                lblHata.Text = "Email veya şifre hatalı!";
            }
        }
    }
}
