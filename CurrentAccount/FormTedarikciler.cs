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
    public partial class FormTedarikciler : Form
    {
        public FormTedarikciler()
        {
            InitializeComponent();
        }
        private void FormTedarikciler_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lsvTedarikciler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir tedarikçi seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvTedarikciler.SelectedItems[0];
            Supplier supplier = (Supplier)item.Tag;
            Singleton.Context.Suppliers.Remove(supplier);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Tedarikçi Silindi");
            ListeGuncelle();
        }   
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lsvTedarikciler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir tedarikçi seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvTedarikciler.SelectedItems[0];
            Supplier supplier = (Supplier)item.Tag;

            FormTedarikciGuncelle frm = new FormTedarikciGuncelle(supplier, Singleton.Context);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FormTedarikciEkle frm = new FormTedarikciEkle();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void ListeGuncelle()
        {
            lsvTedarikciler.Items.Clear();
            var supplier = Singleton.Context.Suppliers.ToList();
            foreach (var item in supplier)
            {
                string[] degerler = new string[5]
                {
                    item.ID.ToString(),
                    item.CompanyName,
                    item.Phone,
                    item.Email,
                    item.Adress
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvTedarikciler.Items.Add(viewItem);
            }
        }
        public void ListeGuncelle(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
    }
}
