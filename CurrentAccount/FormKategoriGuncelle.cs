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
    public partial class FormKategoriGuncelle : Form
    {
        private Category _category;        

        public FormKategoriGuncelle(Category category, CurrentAccountContext db)
        {
            InitializeComponent();
            _category = category;       
        }
        private void FormKategoriGuncelle_Load(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = _category.CategoryName;
            txtAciklama.Text = _category.Description;
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (VeriGirisKontrol() == false)
            {
                return;
            }
            _category.CategoryName = txtKategoriAdi.Text.Trim();
            _category.Description = txtAciklama.Text.Trim();
            WinFormHelpers.KontrolluKaydet(Singleton.Context, this,"Kategori Güncellendi");
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
