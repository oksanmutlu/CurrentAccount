using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrentAccount
{
    class WinFormHelpers
    {
        public static void OndalikliSayiyaIzinVer(object sender, KeyPressEventArgs e)
        {
            Control control = sender as Control;
            e.Handled = true;

            if (char.IsNumber(e.KeyChar) || (e.KeyChar == ',' && !control.Text.Contains(",")))
            {
                control.Text += e.KeyChar;
            }

            if (e.KeyChar == 8 && control.Text.Length > 0)
            {
                control.Text = control.Text.Substring(0, control.Text.Length - 1);
            }

        }

        public static void TamSayiyaIzinVer(object sender, KeyPressEventArgs e)
        {
            TextBoxBase control = sender as TextBoxBase;
            e.Handled = true;

            if (char.IsNumber(e.KeyChar))
            {
                control.Text += e.KeyChar;
            }

            if (e.KeyChar == 8 && control.Text.Length > 0)
            {
                control.Text = control.Text.Substring(0, control.Text.Length - 1);
            }

        }

   
        public static void ErrorReset(object sender, KeyEventArgs e)
        {
            TextBoxBase control = sender as TextBoxBase;
            if (control.Tag != null)
            {
                ErrorProvider provider = control.Tag as ErrorProvider;
                provider.Clear();
                control.Tag = null;
            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="db">ilgili context</param>
        /// <param name="form">işlem başarılı ise kapatılacak olan form verilir</param>
        public static void KontrolluKaydet(DbContext db, Form form,string mesaj)
        {
            try
            {
                int ess = db.SaveChanges();
                if (ess > 0)
                {
                    MessageBox.Show(mesaj);
                    form.Close();
                }
                else
                {
                    MessageBox.Show("Herhangi işlem yapılamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
        public static void KontrolluKaydet(DbContext db, string mesaj)
        {
            try
            {
                int ess = db.SaveChanges();
                if (ess > 0)
                {
                    MessageBox.Show(mesaj);
                }
                else
                {
                    MessageBox.Show("Herhangi işlem yapılamadı");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }
        }
    }
}
