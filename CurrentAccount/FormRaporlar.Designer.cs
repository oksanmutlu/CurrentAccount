namespace CurrentAccount
{
    partial class FormRaporlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRaporlar));
            this.grbFiltrele = new System.Windows.Forms.GroupBox();
            this.lblCalisan = new System.Windows.Forms.Label();
            this.cmbCalisan = new System.Windows.Forms.ComboBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.lblArasinda = new System.Windows.Forms.Label();
            this.lblTarihAraligi = new System.Windows.Forms.Label();
            this.dtpBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblMusteri = new System.Windows.Forms.Label();
            this.lblUrun = new System.Windows.Forms.Label();
            this.cmbUrun = new System.Windows.Forms.ComboBox();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.grbSonuc = new System.Windows.Forms.GroupBox();
            this.lsvRaporlar = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdedi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Musteri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatisTarihi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndirimOrani = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IndirimliFiyat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatisiYapan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.grbKarZarar = new System.Windows.Forms.GroupBox();
            this.lblKarZarar = new System.Windows.Forms.Label();
            this.grbFiltrele.SuspendLayout();
            this.grbSonuc.SuspendLayout();
            this.grbKarZarar.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbFiltrele
            // 
            this.grbFiltrele.Controls.Add(this.lblCalisan);
            this.grbFiltrele.Controls.Add(this.cmbCalisan);
            this.grbFiltrele.Controls.Add(this.btnFiltrele);
            this.grbFiltrele.Controls.Add(this.lblArasinda);
            this.grbFiltrele.Controls.Add(this.lblTarihAraligi);
            this.grbFiltrele.Controls.Add(this.dtpBitis);
            this.grbFiltrele.Controls.Add(this.dtpBaslangic);
            this.grbFiltrele.Controls.Add(this.lblMusteri);
            this.grbFiltrele.Controls.Add(this.lblUrun);
            this.grbFiltrele.Controls.Add(this.cmbUrun);
            this.grbFiltrele.Controls.Add(this.cmbMusteri);
            this.grbFiltrele.Location = new System.Drawing.Point(13, 13);
            this.grbFiltrele.Name = "grbFiltrele";
            this.grbFiltrele.Size = new System.Drawing.Size(775, 113);
            this.grbFiltrele.TabIndex = 0;
            this.grbFiltrele.TabStop = false;
            this.grbFiltrele.Text = "Filtrele";
            // 
            // lblCalisan
            // 
            this.lblCalisan.AutoSize = true;
            this.lblCalisan.Location = new System.Drawing.Point(390, 32);
            this.lblCalisan.Name = "lblCalisan";
            this.lblCalisan.Size = new System.Drawing.Size(44, 13);
            this.lblCalisan.TabIndex = 23;
            this.lblCalisan.Text = "Çalışan:";
            // 
            // cmbCalisan
            // 
            this.cmbCalisan.FormattingEnabled = true;
            this.cmbCalisan.Location = new System.Drawing.Point(438, 29);
            this.cmbCalisan.Name = "cmbCalisan";
            this.cmbCalisan.Size = new System.Drawing.Size(120, 21);
            this.cmbCalisan.TabIndex = 3;
            this.cmbCalisan.TextUpdate += new System.EventHandler(this.CmbCalisan_TextUpdate);
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(589, 73);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(165, 23);
            this.btnFiltrele.TabIndex = 6;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.BtnFiltrele_Click);
            // 
            // lblArasinda
            // 
            this.lblArasinda.AutoSize = true;
            this.lblArasinda.Location = new System.Drawing.Point(307, 78);
            this.lblArasinda.Name = "lblArasinda";
            this.lblArasinda.Size = new System.Drawing.Size(47, 13);
            this.lblArasinda.TabIndex = 20;
            this.lblArasinda.Text = "arasında";
            // 
            // lblTarihAraligi
            // 
            this.lblTarihAraligi.AutoSize = true;
            this.lblTarihAraligi.Location = new System.Drawing.Point(10, 77);
            this.lblTarihAraligi.Name = "lblTarihAraligi";
            this.lblTarihAraligi.Size = new System.Drawing.Size(65, 13);
            this.lblTarihAraligi.TabIndex = 19;
            this.lblTarihAraligi.Text = "Tarih Aralığı:";
            // 
            // dtpBitis
            // 
            this.dtpBitis.Location = new System.Drawing.Point(381, 74);
            this.dtpBitis.MaxDate = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            this.dtpBitis.Name = "dtpBitis";
            this.dtpBitis.Size = new System.Drawing.Size(177, 20);
            this.dtpBitis.TabIndex = 5;
            this.dtpBitis.Value = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            // 
            // dtpBaslangic
            // 
            this.dtpBaslangic.Location = new System.Drawing.Point(81, 74);
            this.dtpBaslangic.MaxDate = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(196, 20);
            this.dtpBaslangic.TabIndex = 4;
            this.dtpBaslangic.Value = new System.DateTime(2019, 10, 3, 0, 0, 0, 0);
            // 
            // lblMusteri
            // 
            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Location = new System.Drawing.Point(10, 32);
            this.lblMusteri.Name = "lblMusteri";
            this.lblMusteri.Size = new System.Drawing.Size(44, 13);
            this.lblMusteri.TabIndex = 16;
            this.lblMusteri.Text = "Müşteri:";
            // 
            // lblUrun
            // 
            this.lblUrun.AutoSize = true;
            this.lblUrun.Location = new System.Drawing.Point(196, 32);
            this.lblUrun.Name = "lblUrun";
            this.lblUrun.Size = new System.Drawing.Size(33, 13);
            this.lblUrun.TabIndex = 15;
            this.lblUrun.Text = "Ürün:";
            // 
            // cmbUrun
            // 
            this.cmbUrun.FormattingEnabled = true;
            this.cmbUrun.Location = new System.Drawing.Point(233, 29);
            this.cmbUrun.Name = "cmbUrun";
            this.cmbUrun.Size = new System.Drawing.Size(121, 21);
            this.cmbUrun.TabIndex = 1;
            this.cmbUrun.TextUpdate += new System.EventHandler(this.CmbUrun_TextUpdate);
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(58, 29);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(121, 21);
            this.cmbMusteri.TabIndex = 0;
            this.cmbMusteri.TextUpdate += new System.EventHandler(this.CmbMusteri_TextUpdate);
            // 
            // grbSonuc
            // 
            this.grbSonuc.Controls.Add(this.lsvRaporlar);
            this.grbSonuc.Location = new System.Drawing.Point(13, 132);
            this.grbSonuc.Name = "grbSonuc";
            this.grbSonuc.Size = new System.Drawing.Size(775, 262);
            this.grbSonuc.TabIndex = 1;
            this.grbSonuc.TabStop = false;
            this.grbSonuc.Text = "Sonuç";
            // 
            // lsvRaporlar
            // 
            this.lsvRaporlar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.UrunAdi,
            this.UrunAdedi,
            this.Musteri,
            this.SatisTarihi,
            this.IndirimOrani,
            this.IndirimliFiyat,
            this.SatisiYapan});
            this.lsvRaporlar.FullRowSelect = true;
            this.lsvRaporlar.GridLines = true;
            this.lsvRaporlar.HideSelection = false;
            this.lsvRaporlar.Location = new System.Drawing.Point(6, 19);
            this.lsvRaporlar.Name = "lsvRaporlar";
            this.lsvRaporlar.Size = new System.Drawing.Size(763, 237);
            this.lsvRaporlar.TabIndex = 7;
            this.lsvRaporlar.UseCompatibleStateImageBehavior = false;
            this.lsvRaporlar.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 82;
            // 
            // UrunAdedi
            // 
            this.UrunAdedi.Text = "Ürün Adedi";
            this.UrunAdedi.Width = 81;
            // 
            // Musteri
            // 
            this.Musteri.Text = "Müşteri";
            this.Musteri.Width = 103;
            // 
            // SatisTarihi
            // 
            this.SatisTarihi.Text = "Satış Tarihi";
            this.SatisTarihi.Width = 128;
            // 
            // IndirimOrani
            // 
            this.IndirimOrani.Text = "İndirim Oranı (%)";
            this.IndirimOrani.Width = 88;
            // 
            // IndirimliFiyat
            // 
            this.IndirimliFiyat.Text = "İndirimli Fiyatı";
            this.IndirimliFiyat.Width = 97;
            // 
            // SatisiYapan
            // 
            this.SatisiYapan.Text = "Satışı Yapan";
            this.SatisiYapan.Width = 103;
            // 
            // grbKarZarar
            // 
            this.grbKarZarar.Controls.Add(this.lblKarZarar);
            this.grbKarZarar.Location = new System.Drawing.Point(13, 401);
            this.grbKarZarar.Name = "grbKarZarar";
            this.grbKarZarar.Size = new System.Drawing.Size(775, 37);
            this.grbKarZarar.TabIndex = 2;
            this.grbKarZarar.TabStop = false;
            this.grbKarZarar.Text = "Genel Kar-Zarar Durumu";
            // 
            // lblKarZarar
            // 
            this.lblKarZarar.AutoSize = true;
            this.lblKarZarar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKarZarar.Location = new System.Drawing.Point(222, 11);
            this.lblKarZarar.Name = "lblKarZarar";
            this.lblKarZarar.Size = new System.Drawing.Size(0, 20);
            this.lblKarZarar.TabIndex = 0;
            // 
            // FormRaporlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbKarZarar);
            this.Controls.Add(this.grbSonuc);
            this.Controls.Add(this.grbFiltrele);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormRaporlar";
            this.Text = "Raporlar";
            this.grbFiltrele.ResumeLayout(false);
            this.grbFiltrele.PerformLayout();
            this.grbSonuc.ResumeLayout(false);
            this.grbKarZarar.ResumeLayout(false);
            this.grbKarZarar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbFiltrele;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.Label lblArasinda;
        private System.Windows.Forms.Label lblTarihAraligi;
        private System.Windows.Forms.DateTimePicker dtpBitis;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblMusteri;
        private System.Windows.Forms.Label lblUrun;
        private System.Windows.Forms.ComboBox cmbUrun;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.GroupBox grbSonuc;
        private System.Windows.Forms.GroupBox grbKarZarar;
        private System.Windows.Forms.Label lblKarZarar;
        private System.Windows.Forms.Label lblCalisan;
        private System.Windows.Forms.ComboBox cmbCalisan;
        private System.Windows.Forms.ListView lsvRaporlar;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader UrunAdedi;
        private System.Windows.Forms.ColumnHeader Musteri;
        private System.Windows.Forms.ColumnHeader SatisTarihi;
        private System.Windows.Forms.ColumnHeader IndirimOrani;
        private System.Windows.Forms.ColumnHeader IndirimliFiyat;
        private System.Windows.Forms.ColumnHeader SatisiYapan;
    }
}