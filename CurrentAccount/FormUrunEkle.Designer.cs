namespace CurrentAccount
{
    partial class FormUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunEkle));
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblTedarikci = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblKategorisi = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblAlisFiyati = new System.Windows.Forms.Label();
            this.txtAlisFiyati = new System.Windows.Forms.TextBox();
            this.lblSatisFiyati = new System.Windows.Forms.Label();
            this.txtSatisFiyati = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.cmbTedarikciler = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(30, 179);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(53, 13);
            this.lblAciklama.TabIndex = 39;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // lblTedarikci
            // 
            this.lblTedarikci.AutoSize = true;
            this.lblTedarikci.Location = new System.Drawing.Point(30, 73);
            this.lblTedarikci.Name = "lblTedarikci";
            this.lblTedarikci.Size = new System.Drawing.Size(54, 13);
            this.lblTedarikci.TabIndex = 38;
            this.lblTedarikci.Text = "Tedarikçi:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(30, 47);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(51, 13);
            this.lblUrunAdi.TabIndex = 37;
            this.lblUrunAdi.Text = "Ürün Adı:";
            // 
            // lblKategorisi
            // 
            this.lblKategorisi.AutoSize = true;
            this.lblKategorisi.Location = new System.Drawing.Point(30, 21);
            this.lblKategorisi.Name = "lblKategorisi";
            this.lblKategorisi.Size = new System.Drawing.Size(56, 13);
            this.lblKategorisi.TabIndex = 36;
            this.lblKategorisi.Text = "Kategorisi:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(112, 176);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(150, 76);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(112, 44);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(150, 20);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(187, 258);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 7;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.AutoSize = true;
            this.lblAlisFiyati.Location = new System.Drawing.Point(30, 99);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(53, 13);
            this.lblAlisFiyati.TabIndex = 41;
            this.lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // txtAlisFiyati
            // 
            this.txtAlisFiyati.Location = new System.Drawing.Point(112, 96);
            this.txtAlisFiyati.Name = "txtAlisFiyati";
            this.txtAlisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtAlisFiyati.TabIndex = 3;
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.AutoSize = true;
            this.lblSatisFiyati.Location = new System.Drawing.Point(30, 125);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(60, 13);
            this.lblSatisFiyati.TabIndex = 43;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtSatisFiyati
            // 
            this.txtSatisFiyati.Location = new System.Drawing.Point(112, 122);
            this.txtSatisFiyati.Name = "txtSatisFiyati";
            this.txtSatisFiyati.Size = new System.Drawing.Size(150, 20);
            this.txtSatisFiyati.TabIndex = 4;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(30, 151);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(32, 13);
            this.lblStok.TabIndex = 45;
            this.lblStok.Text = "Stok:";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(112, 148);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(150, 20);
            this.txtStok.TabIndex = 5;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(112, 18);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(150, 21);
            this.cmbKategoriler.TabIndex = 0;
            // 
            // cmbTedarikciler
            // 
            this.cmbTedarikciler.FormattingEnabled = true;
            this.cmbTedarikciler.Location = new System.Drawing.Point(112, 70);
            this.cmbTedarikciler.Name = "cmbTedarikciler";
            this.cmbTedarikciler.Size = new System.Drawing.Size(150, 21);
            this.cmbTedarikciler.TabIndex = 2;
            // 
            // FormUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 295);
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
            this.Controls.Add(this.btnEkle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrunEkle";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.FormUrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblTedarikci;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.Label lblKategorisi;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblAlisFiyati;
        private System.Windows.Forms.TextBox txtAlisFiyati;
        private System.Windows.Forms.Label lblSatisFiyati;
        private System.Windows.Forms.TextBox txtSatisFiyati;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.ComboBox cmbTedarikciler;
    }
}