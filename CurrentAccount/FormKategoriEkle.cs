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
    public partial class FormKategoriEkle : Form
    {  
        public FormKategoriEkle()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            Category categories = new Category()
            {
                CategoryName = txtKategoriAdi.Text.Trim(),
                Description = txtAciklama.Text.Trim()
            };
            Singleton.Context.Categories.Add(categories);
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Kategori Eklendi");
        }
        private bool VeriGirisKontrol()
        {
            string kontrol = string.IsNullOrWhiteSpace(txtKategoriAdi.Text) ? "Kategori Adı \n" : "";
            kontrol += string.IsNullOrWhiteSpace(txtAciklama.Text) ? "Açıklama \n" : "";
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
