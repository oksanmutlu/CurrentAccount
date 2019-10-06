namespace CurrentAccount
{
    partial class FormSifreDegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSifreDegistir));
            this.lblYeniSifreTekrar = new System.Windows.Forms.Label();
            this.lblYeniSifre = new System.Windows.Forms.Label();
            this.lblEskiSifre = new System.Windows.Forms.Label();
            this.txtYeniSifreTekrar = new System.Windows.Forms.TextBox();
            this.txtYeniSifre = new System.Windows.Forms.TextBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.btnSifreyiDegistir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblYeniSifreTekrar
            // 
            this.lblYeniSifreTekrar.AutoSize = true;
            this.lblYeniSifreTekrar.Location = new System.Drawing.Point(20, 75);
            this.lblYeniSifreTekrar.Name = "lblYeniSifreTekrar";
            this.lblYeniSifreTekrar.Size = new System.Drawing.Size(89, 13);
            this.lblYeniSifreTekrar.TabIndex = 14;
            this.lblYeniSifreTekrar.Text = "Yeni Şifre Tekrar:";
            // 
            // lblYeniSifre
            // 
            this.lblYeniSifre.AutoSize = true;
            this.lblYeniSifre.Location = new System.Drawing.Point(20, 49);
            this.lblYeniSifre.Name = "lblYeniSifre";
            this.lblYeniSifre.Size = new System.Drawing.Size(55, 13);
            this.lblYeniSifre.TabIndex = 13;
            this.lblYeniSifre.Text = "Yeni Şifre:";
            // 
            // lblEskiSifre
            // 
            this.lblEskiSifre.AutoSize = true;
            this.lblEskiSifre.Location = new System.Drawing.Point(20, 23);
            this.lblEskiSifre.Name = "lblEskiSifre";
            this.lblEskiSifre.Size = new System.Drawing.Size(54, 13);
            this.lblEskiSifre.TabIndex = 12;
            this.lblEskiSifre.Text = "Eski Şifre:";
            // 
            // txtYeniSifreTekrar
            // 
            this.txtYeniSifreTekrar.Location = new System.Drawing.Point(113, 72);
            this.txtYeniSifreTekrar.MaxLength = 30;
            this.txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            this.txtYeniSifreTekrar.Size = new System.Drawing.Size(150, 20);
            this.txtYeniSifreTekrar.TabIndex = 2;
            this.txtYeniSifreTekrar.UseSystemPasswordChar = true;
            // 
            // txtYeniSifre
            // 
            this.txtYeniSifre.Location = new System.Drawing.Point(113, 46);
            this.txtYeniSifre.MaxLength = 30;
            this.txtYeniSifre.Name = "txtYeniSifre";
            this.txtYeniSifre.Size = new System.Drawing.Size(150, 20);
            this.txtYeniSifre.TabIndex = 1;
            this.txtYeniSifre.UseSystemPasswordChar = true;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(113, 20);
            this.txtEskiSifre.MaxLength = 30;
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(150, 20);
            this.txtEskiSifre.TabIndex = 0;
            this.txtEskiSifre.UseSystemPasswordChar = true;
            // 
            // btnSifreyiDegistir
            // 
            this.btnSifreyiDegistir.Location = new System.Drawing.Point(178, 98);
            this.btnSifreyiDegistir.Name = "btnSifreyiDegistir";
            this.btnSifreyiDegistir.Size = new System.Drawing.Size(85, 23);
            this.btnSifreyiDegistir.TabIndex = 3;
            this.btnSifreyiDegistir.Text = "Şifreyi Değiştir";
            this.btnSifreyiDegistir.UseVisualStyleBackColor = true;
            this.btnSifreyiDegistir.Click += new System.EventHandler(this.BtnSifreyiDegistir_Click);
            // 
            // FormSifreDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 140);
            this.Controls.Add(this.btnSifreyiDegistir);
            this.Controls.Add(this.lblYeniSifreTekrar);
            this.Controls.Add(this.lblYeniSifre);
            this.Controls.Add(this.lblEskiSifre);
            this.Controls.Add(this.txtYeniSifreTekrar);
            this.Controls.Add(this.txtYeniSifre);
            this.Controls.Add(this.txtEskiSifre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSifreDegistir";
            this.Text = "Şifre Değiştir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYeniSifreTekrar;
        private System.Windows.Forms.Label lblYeniSifre;
        private System.Windows.Forms.Label lblEskiSifre;
        private System.Windows.Forms.TextBox txtYeniSifreTekrar;
        private System.Windows.Forms.TextBox txtYeniSifre;
        private System.Windows.Forms.TextBox txtEskiSifre;
        private System.Windows.Forms.Button btnSifreyiDegistir;
    }
}