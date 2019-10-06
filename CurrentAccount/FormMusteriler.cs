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
    public partial class FormMusteriler : Form
    {
        public FormMusteriler()
        {
            InitializeComponent();
        }

        private void FormMusteriler_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }


        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FormMusteriEkle frm = new FormMusteriEkle();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {


            if (lsvMusteriler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir müşteri seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvMusteriler.SelectedItems[0];
            Customer customer = (Customer)item.Tag;

            FormMusteriGuncelle frm = new FormMusteriGuncelle(customer, Singleton.Context);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();

        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lsvMusteriler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir müşteri seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvMusteriler.SelectedItems[0];
            Customer customer = (Customer)item.Tag;
            Singleton.Context.Customers.Remove(customer);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Müşteri silindi");
            ListeGuncelle();
        }

        private void ListeGuncelle()
        {
            lsvMusteriler.Items.Clear();
            var customer = Singleton.Context.Customers.ToList();
            foreach (var item in customer)
            {
                string[] degerler = new string[6]
                {
                    item.ID.ToString(),
                    item.FirstName,
                    item.LastName,
                    item.Phone,
                    item.Email,
                    item.Adress
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvMusteriler.Items.Add(viewItem);
            }
        }

        public void ListeGuncelle(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
    }
}
