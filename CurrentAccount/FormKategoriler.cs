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
    public partial class FormKategoriler : Form
    {
        public FormKategoriler()
        {
            InitializeComponent();
            Load += ListeGuncelle;
        }

        private void FormKategoriler_Load(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (lsvKategoriler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Güncelleme işlemi öncesinde bir kategori seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvKategoriler.SelectedItems[0];
            Category category = (Category)item.Tag;

            FormKategoriGuncelle frm = new FormKategoriGuncelle(category, Singleton.Context);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            FormKategoriEkle frm = new FormKategoriEkle();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += ListeGuncelle;
            frm.Show();
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (lsvKategoriler.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Silme işlemi öncesinde bir kategori seçmeniz gerekmektedir.");
                return;
            }
            var item = lsvKategoriler.SelectedItems[0];
            Category category = (Category)item.Tag;
            Singleton.Context.Categories.Remove(category);
            WinFormHelpers.KontrolluKaydet(Singleton.Context,"Kategori Silindi");
            ListeGuncelle();
        }
        private void ListeGuncelle()
        {
            lsvKategoriler.Items.Clear();
            var category = Singleton.Context.Categories.ToList();
            foreach (var item in category)
            {
                string[] degerler = new string[3]
                {
                    item.ID.ToString(),
                    item.CategoryName,
                    item.Description
                };
                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;
                lsvKategoriler.Items.Add(viewItem);
            }
        }
        public void ListeGuncelle(object sender, EventArgs e)
        {
            ListeGuncelle();
        }
    }
}
