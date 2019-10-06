﻿namespace CurrentAccount
{
    partial class FormUrunler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUrunler));
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lsvUrunler = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UrunAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Kategorisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AlisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SatisFiyati = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stok = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tedarikcisi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Aciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(713, 417);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(94, 417);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 417);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // lsvUrunler
            // 
            this.lsvUrunler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.UrunAdi,
            this.Kategorisi,
            this.AlisFiyati,
            this.SatisFiyati,
            this.Stok,
            this.Tedarikcisi,
            this.Aciklama});
            this.lsvUrunler.FullRowSelect = true;
            this.lsvUrunler.GridLines = true;
            this.lsvUrunler.HideSelection = false;
            this.lsvUrunler.Location = new System.Drawing.Point(12, 10);
            this.lsvUrunler.Name = "lsvUrunler";
            this.lsvUrunler.Size = new System.Drawing.Size(776, 401);
            this.lsvUrunler.TabIndex = 0;
            this.lsvUrunler.UseCompatibleStateImageBehavior = false;
            this.lsvUrunler.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 51;
            // 
            // UrunAdi
            // 
            this.UrunAdi.Text = "Ürün Adı";
            this.UrunAdi.Width = 90;
            // 
            // Kategorisi
            // 
            this.Kategorisi.Text = "Kategorisi";
            this.Kategorisi.Width = 100;
            // 
            // AlisFiyati
            // 
            this.AlisFiyati.Text = "Alış Fiyatı";
            this.AlisFiyati.Width = 94;
            // 
            // SatisFiyati
            // 
            this.SatisFiyati.Text = "SatışFiyatı";
            this.SatisFiyati.Width = 86;
            // 
            // Stok
            // 
            this.Stok.Text = "Stok";
            this.Stok.Width = 88;
            // 
            // Tedarikcisi
            // 
            this.Tedarikcisi.Text = "Tedarikçisi";
            this.Tedarikcisi.Width = 105;
            // 
            // Aciklama
            // 
            this.Aciklama.Text = "Açıklama";
            this.Aciklama.Width = 155;
            // 
            // FormUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lsvUrunler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FormUrunler_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListView lsvUrunler;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader UrunAdi;
        private System.Windows.Forms.ColumnHeader Kategorisi;
        private System.Windows.Forms.ColumnHeader AlisFiyati;
        private System.Windows.Forms.ColumnHeader SatisFiyati;
        private System.Windows.Forms.ColumnHeader Stok;
        private System.Windows.Forms.ColumnHeader Aciklama;
        private System.Windows.Forms.ColumnHeader Tedarikcisi;
    }
}