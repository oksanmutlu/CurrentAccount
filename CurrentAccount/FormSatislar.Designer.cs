namespace CurrentAccount
{
    partial class FormSatislar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSatislar));
            this.lsvSatislar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Musteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndirimOrani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndirimliFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatisiYapan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.lblUrun = new System.Windows.Forms.Label();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblIndirim = new System.Windows.Forms.Label();
            this.txtToplam = new System.Windows.Forms.TextBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.btnSat = new System.Windows.Forms.Button();
            this.nudIndirim = new System.Windows.Forms.NumericUpDown();
            this.btnSatisIptal = new System.Windows.Forms.Button();
            this.nudAdet = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvSatislar
            // 
            this.lsvSatislar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.UrunAdi,
            this.UrunAdedi,
            this.Musteri,
            this.SatisTarihi,
            this.IndirimOrani,
            this.IndirimliFiyat,
            this.SatisiYapan});
            this.lsvSatislar.FullRowSelect = true;
            this.lsvSatislar.GridLines = true;
            this.lsvSatislar.HideSelection = false;
            this.lsvSatislar.Location = new System.Drawing.Point(12, 87);
            this.lsvSatislar.Name = "lsvSatislar";
            this.lsvSatislar.Size = new System.Drawing.Size(776, 313);
            this.lsvSatislar.TabIndex = 6;
            this.lsvSatislar.UseCompatibleStateImageBehavior = false;
            this.lsvSatislar.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 38;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 94;
            // 
            // UrunAdedi
            // 
            this.UrunAdedi.Text = "Ürün Adedi";
            this.UrunAdedi.Width = 80;
            // 
            // Musteri
            // 
            this.Musteri.Text = "Müşteri";
            this.Musteri.Width = 137;
            // 
            // SatisTarihi
            // 
            this.SatisTarihi.Text = "Satış Tarihi";
            this.SatisTarihi.Width = 122;
            // 
            // IndirimOrani
            // 
            this.IndirimOrani.Text = "İndirim Oranı (%)";
            this.IndirimOrani.Width = 93;
            // 
            // IndirimliFiyat
            // 
            this.IndirimliFiyat.Text = "İndirimli Fiyatı";
            this.IndirimliFiyat.Width = 93;
            // 
            // SatisiYapan
            // 
            this.SatisiYapan.Text = "Satışı Yapan";
            this.SatisiYapan.Width = 82;
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(93, 17);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(120, 21);
            this.cmbMusteri.TabIndex = 0;
            this.cmbMusteri.TextUpdate += new System.EventHandler(this.CmbMusteri_TextUpdate);
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(327, 17);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.SelectedIndexChanged += new System.EventHandler(this.CmbUrun_SelectedIndexChanged);
            this.cmbUrun.TextUpdate += new System.EventHandler(this.CmbUrun_TextUpdate);
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(267, 20);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(51, 13);
            this.lblUrun.TabIndex = 9;
            this.lblUrun.Text = "Ürün Adı:";
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(27, 20);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(44, 13);
            this.lblMusteri.TabIndex = 10;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Location = new System.Drawing.Point(27, 60);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(63, 13);
            this.lblAdet.TabIndex = 12;
            this.lblAdet.Text = "Ürün Adedi:";
            // 
            // lblIndirim
            // 
            this.lblIndirim.AutoSize = true;
            this.lblIndirim.Location = new System.Drawing.Point(267, 59);
            this.lblIndirim.Name = "lblIndirim";
            this.lblIndirim.Size = new System.Drawing.Size(54, 13);
            this.lblIndirim.TabIndex = 14;
            this.lblIndirim.Text = "İndirim(%):";
            // 
            // txtToplam
            // 
            this.txtToplam.Enabled = false;
            this.txtToplam.Location = new System.Drawing.Point(542, 56);
            this.txtToplam.Name = "txtToplam";
            this.txtToplam.Size = new System.Drawing.Size(112, 20);
            this.txtToplam.TabIndex = 4;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(491, 60);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(45, 13);
            this.lblToplam.TabIndex = 16;
            this.lblToplam.Text = "Toplam:";
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(697, 54);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(91, 23);
            this.btnSat.TabIndex = 5;
            this.btnSat.Text = "Sat";
            this.btnSat.UseVisualStyleBackColor = true;
            this.btnSat.Click += new System.EventHandler(this.BtnSat_Click);
            // 
            // nudIndirim
            // 
            this.nudIndirim.Location = new System.Drawing.Point(327, 58);
            this.nudIndirim.Name = "nudIndirim";
            this.nudIndirim.Size = new System.Drawing.Size(121, 20);
            this.nudIndirim.TabIndex = 3;
            this.nudIndirim.ValueChanged += new System.EventHandler(this.NudAdet_ValueChanged);
            // 
            // btnSatisIptal
            // 
            this.btnSatisIptal.Location = new System.Drawing.Point(697, 406);
            this.btnSatisIptal.Name = "btnSatisIptal";
            this.btnSatisIptal.Size = new System.Drawing.Size(91, 23);
            this.btnSatisIptal.TabIndex = 7;
            this.btnSatisIptal.Text = "Satış İptal";
            this.btnSatisIptal.UseVisualStyleBackColor = true;
            this.btnSatisIptal.Click += new System.EventHandler(this.BtnSatisIptal_Click);
            // 
            // nudAdet
            // 
            this.nudAdet.Location = new System.Drawing.Point(93, 57);
            this.nudAdet.Name = "nudAdet";
            this.nudAdet.Size = new System.Drawing.Size(120, 20);
            this.nudAdet.TabIndex = 2;
            this.nudAdet.ValueChanged += new System.EventHandler(this.NudAdet_ValueChanged);
            // 
            // FormSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 441);
            this.Controls.Add(this.nudAdet);
            this.Controls.Add(this.btnSatisIptal);
            this.Controls.Add(this.nudIndirim);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.txtToplam);
            this.Controls.Add(this.lblIndirim);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblMusteri);
            this.Controls.Add(this.lblUrun);
            this.Controls.Add(this.cmbUrun);
            this.Controls.Add(this.cmbMusteri);
            this.Controls.Add(this.lsvSatislar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSatislar";
            this.Text = "Satışlar";
            this.Load += new System.EventHandler(this.FormSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudIndirim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvSatislar;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunAdedi;
        private System.Windows.Forms.ColumnHeader Musteri;
        private System.Windows.Forms.ColumnHeader SatisTarihi;
        private System.Windows.Forms.ColumnHeader IndirimOrani;
        private System.Windows.Forms.ColumnHeader IndirimliFiyat;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblIndirim;
        private System.Windows.Forms.TextBox txtToplam;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Button btnSat;
        private System.Windows.Forms.NumericUpDown nudIndirim;
        private System.Windows.Forms.Button btnSatisIptal;
        private System.Windows.Forms.NumericUpDown nudAdet;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader SatisiYapan;
    }
}