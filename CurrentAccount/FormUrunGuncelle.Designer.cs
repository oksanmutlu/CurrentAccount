namespace CurrentAccount
{
    partial class FormUrunGuncelle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunGuncelle));
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblKategorisi = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(113, 99);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(150, 21);
            this.cmbTedarikciler.TabIndex = 3;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(113, 47);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(150, 21);
            this.cmbKategoriler.TabIndex = 1;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(31, 180);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 13);
            this.lblStok.TabIndex = 60;
            this.lblStok.Text = "Stok:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(113, 177);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(150, 20);
            this.txtStok.TabIndex = 6;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(31, 154);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(60, 13);
            this.lblSatisFiyati.TabIndex = 58;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(113, 151);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtSatisFiyati.TabIndex = 5;
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Location = new System.Drawing.Point(31, 128);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(53, 13);
            this.lblAlisFiyati.TabIndex = 56;
            this.lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(113, 125);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtAlisFiyati.TabIndex = 4;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(31, 208);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(53, 13);
            this.lblAciklama.TabIndex = 54;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(31, 102);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(54, 13);
            this.lblTedarikci.TabIndex = 53;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(31, 76);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAdi.TabIndex = 52;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblKategorisi
            // 
            this.lblKategorisi.AutoSize = true;
            this.lblKategorisi.Location = new System.Drawing.Point(31, 50);
            this.lblKategorisi.Name = "lblKategorisi";
            this.lblKategorisi.Size = new System.Drawing.Size(56, 13);
            this.lblKategorisi.TabIndex = 51;
            this.lblKategorisi.Text = "Kategorisi:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(113, 205);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(150, 76);
            this.txtAciklama.TabIndex = 7;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(113, 73);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 20);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(188, 287);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 8;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(31, 24);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(47, 13);
            this.lblUrunID.TabIndex = 64;
            this.lblUrunID.Text = "Ürün ID:";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Enabled = false;
            this.txtUrunID.Location = new System.Drawing.Point(113, 21);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(150, 20);
            this.txtUrunID.TabIndex = 0;
            // 
            // FormUrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 323);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.cmbTedarikciler);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.txtSatisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.txtAlisFiyati);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTedarikci);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblKategorisi);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.btnGuncelle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrunGuncelle";
            this.Text = "Ürün Güncelle";
            this.Load += new System.EventHandler(this.FormUrunGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTedarikciler;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblKategorisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.TextBox txtUrunID;
    }
}