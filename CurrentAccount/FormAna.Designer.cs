namespace CurrentAccount
{
    partial class FormAna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAna));
            this.tsMenuler = new System.Windows.Forms.ToolStrip();
            this.tsbMusteriler = new System.Windows.Forms.ToolStripButton();
            this.tsbRaporlar = new System.Windows.Forms.ToolStripButton();
            this.tsbSatislar = new System.Windows.Forms.ToolStripButton();
            this.tsbUrunler = new System.Windows.Forms.ToolStripButton();
            this.tsbKategoriler = new System.Windows.Forms.ToolStripButton();
            this.tsbTedarikciler = new System.Windows.Forms.ToolStripButton();
            this.tsbKullaniciAyarlari = new System.Windows.Forms.ToolStripButton();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.tsMenuler.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMenuler
            // 
            this.tsMenuler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbMusteriler,
            this.tsbRaporlar,
            this.tsbSatislar,
            this.tsbUrunler,
            this.tsbKategoriler,
            this.tsbTedarikciler,
            this.tsbKullaniciAyarlari});
            this.tsMenuler.Location = new System.Drawing.Point(0, 0);
            this.tsMenuler.Name = "tsMenuler";
            this.tsMenuler.Size = new System.Drawing.Size(800, 28);
            this.tsMenuler.TabIndex = 4;
            this.tsMenuler.Text = "toolStrip1";
            // 
            // tsbMusteriler
            // 
            this.tsbMusteriler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbMusteriler.Image = ((System.Drawing.Image)(resources.GetObject("tsbMusteriler.Image")));
            this.tsbMusteriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMusteriler.Name = "tsbMusteriler";
            this.tsbMusteriler.Size = new System.Drawing.Size(101, 25);
            this.tsbMusteriler.Text = "Müşteriler";
            this.tsbMusteriler.Click += new System.EventHandler(this.TsbMusteriler_Click);
            // 
            // tsbRaporlar
            // 
            this.tsbRaporlar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbRaporlar.Image = ((System.Drawing.Image)(resources.GetObject("tsbRaporlar.Image")));
            this.tsbRaporlar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRaporlar.Name = "tsbRaporlar";
            this.tsbRaporlar.Size = new System.Drawing.Size(90, 25);
            this.tsbRaporlar.Text = "Raporlar";
            this.tsbRaporlar.ToolTipText = "Raporlar";
            this.tsbRaporlar.Click += new System.EventHandler(this.TsbRaporlar_Click);
            // 
            // tsbSatislar
            // 
            this.tsbSatislar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbSatislar.Image = ((System.Drawing.Image)(resources.GetObject("tsbSatislar.Image")));
            this.tsbSatislar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSatislar.Name = "tsbSatislar";
            this.tsbSatislar.Size = new System.Drawing.Size(81, 25);
            this.tsbSatislar.Text = "Satışlar";
            this.tsbSatislar.Click += new System.EventHandler(this.TsbSatislar_Click);
            // 
            // tsbUrunler
            // 
            this.tsbUrunler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbUrunler.Image = ((System.Drawing.Image)(resources.GetObject("tsbUrunler.Image")));
            this.tsbUrunler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUrunler.Name = "tsbUrunler";
            this.tsbUrunler.Size = new System.Drawing.Size(83, 25);
            this.tsbUrunler.Text = "Ürünler";
            this.tsbUrunler.Click += new System.EventHandler(this.TsbUrunler_Click);
            // 
            // tsbKategoriler
            // 
            this.tsbKategoriler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbKategoriler.Image = ((System.Drawing.Image)(resources.GetObject("tsbKategoriler.Image")));
            this.tsbKategoriler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKategoriler.Name = "tsbKategoriler";
            this.tsbKategoriler.Size = new System.Drawing.Size(106, 25);
            this.tsbKategoriler.Text = "Kategoriler";
            this.tsbKategoriler.Click += new System.EventHandler(this.TsbKategoriler_Click);
            // 
            // tsbTedarikciler
            // 
            this.tsbTedarikciler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbTedarikciler.Image = ((System.Drawing.Image)(resources.GetObject("tsbTedarikciler.Image")));
            this.tsbTedarikciler.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTedarikciler.Name = "tsbTedarikciler";
            this.tsbTedarikciler.Size = new System.Drawing.Size(108, 25);
            this.tsbTedarikciler.Text = "Tedarikçiler";
            this.tsbTedarikciler.Click += new System.EventHandler(this.TsbTedarikciler_Click);
            // 
            // tsbKullaniciAyarlari
            // 
            this.tsbKullaniciAyarlari.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.tsbKullaniciAyarlari.Image = ((System.Drawing.Image)(resources.GetObject("tsbKullaniciAyarlari.Image")));
            this.tsbKullaniciAyarlari.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKullaniciAyarlari.Name = "tsbKullaniciAyarlari";
            this.tsbKullaniciAyarlari.Size = new System.Drawing.Size(146, 25);
            this.tsbKullaniciAyarlari.Text = "Kullanıcı Ayarları";
            this.tsbKullaniciAyarlari.Click += new System.EventHandler(this.TsbKullaniciAyarlari_Click);
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHosgeldin.Location = new System.Drawing.Point(734, 5);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(87, 17);
            this.lblHosgeldin.TabIndex = 6;
            this.lblHosgeldin.Text = "Hoşgeldin ...";
            // 
            // FormAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.tsMenuler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Hesap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAna_FormClosed);
            this.Load += new System.EventHandler(this.FormAna_Load);
            this.tsMenuler.ResumeLayout(false);
            this.tsMenuler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tsMenuler;
        private System.Windows.Forms.ToolStripButton tsbMusteriler;
        private System.Windows.Forms.ToolStripButton tsbRaporlar;
        private System.Windows.Forms.ToolStripButton tsbSatislar;
        private System.Windows.Forms.ToolStripButton tsbUrunler;
        private System.Windows.Forms.ToolStripButton tsbKategoriler;
        private System.Windows.Forms.ToolStripButton tsbTedarikciler;
        private System.Windows.Forms.ToolStripButton tsbKullaniciAyarlari;
        private System.Windows.Forms.Label lblHosgeldin;
    }
}