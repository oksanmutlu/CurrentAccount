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
    public partial class FormAna : Form
    {
             
        public FormAna()
        {
            InitializeComponent();  
        }


        private void FormAna_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoşgeldin " + Kullanici.adSoyad;
            lblHosgeldin.Left = this.Right - 175;
        }

        private void FormAna_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void TsbMusteriler_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormMusteriler>();
        }

        private void TsbRaporlar_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormRaporlar>();
        }

        private void TsbSatislar_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormSatislar>();
        }

        private void TsbUrunler_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormUrunler>();
        }

        private void TsbKategoriler_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormKategoriler>();
        }

        private void TsbTedarikciler_Click(object sender, EventArgs e)
        {
            this.MdiChildAc<FormTedarikciler>();
        }

        private void TsbKullaniciAyarlari_Click(object sender, EventArgs e)
        {
            if (Kullanici.statu == false)
            {
                this.MdiChildAc<FormSifreDegistir>();
            }
            else
            {
                this.MdiChildAc<FormYoneticiAyarlari>();
            }
        }
    }
}