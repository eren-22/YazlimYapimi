namespace SınavSistemi
{
    partial class Form3
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
            this.lblKayitHg = new System.Windows.Forms.Label();
            this.txtUsernameBelirle = new System.Windows.Forms.TextBox();
            this.txtSifreBelirle = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdiSec = new System.Windows.Forms.Label();
            this.lblSifreSec = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lblSifreTekrar = new System.Windows.Forms.Label();
            this.txtSifreTekrar = new System.Windows.Forms.TextBox();
            this.btnKayitOnay = new System.Windows.Forms.Button();
            this.lblGuvenlik = new System.Windows.Forms.Label();
            this.gBoxGuvenlik = new System.Windows.Forms.GroupBox();
            this.txtGuvenlik = new System.Windows.Forms.TextBox();
            this.gBoxGuvenlik.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKayitHg
            // 
            this.lblKayitHg.AutoSize = true;
            this.lblKayitHg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKayitHg.Location = new System.Drawing.Point(176, 60);
            this.lblKayitHg.Name = "lblKayitHg";
            this.lblKayitHg.Size = new System.Drawing.Size(382, 25);
            this.lblKayitHg.TabIndex = 0;
            this.lblKayitHg.Text = "Uygulama Kayıt Ekranına Hoş Geldiniz";
            // 
            // txtUsernameBelirle
            // 
            this.txtUsernameBelirle.Location = new System.Drawing.Point(229, 121);
            this.txtUsernameBelirle.Name = "txtUsernameBelirle";
            this.txtUsernameBelirle.Size = new System.Drawing.Size(138, 22);
            this.txtUsernameBelirle.TabIndex = 1;
            // 
            // txtSifreBelirle
            // 
            this.txtSifreBelirle.Location = new System.Drawing.Point(229, 165);
            this.txtSifreBelirle.Name = "txtSifreBelirle";
            this.txtSifreBelirle.Size = new System.Drawing.Size(138, 22);
            this.txtSifreBelirle.TabIndex = 2;
            // 
            // lblKullaniciAdiSec
            // 
            this.lblKullaniciAdiSec.AutoSize = true;
            this.lblKullaniciAdiSec.Location = new System.Drawing.Point(62, 126);
            this.lblKullaniciAdiSec.Name = "lblKullaniciAdiSec";
            this.lblKullaniciAdiSec.Size = new System.Drawing.Size(88, 16);
            this.lblKullaniciAdiSec.TabIndex = 3;
            this.lblKullaniciAdiSec.Text = "Kullanıcı Adı : ";
            // 
            // lblSifreSec
            // 
            this.lblSifreSec.AutoSize = true;
            this.lblSifreSec.Location = new System.Drawing.Point(62, 171);
            this.lblSifreSec.Name = "lblSifreSec";
            this.lblSifreSec.Size = new System.Drawing.Size(40, 16);
            this.lblSifreSec.TabIndex = 4;
            this.lblSifreSec.Text = "Şifre :";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(566, 300);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Bilgilerim Doğru";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // lblSifreTekrar
            // 
            this.lblSifreTekrar.AutoSize = true;
            this.lblSifreTekrar.Location = new System.Drawing.Point(62, 219);
            this.lblSifreTekrar.Name = "lblSifreTekrar";
            this.lblSifreTekrar.Size = new System.Drawing.Size(141, 16);
            this.lblSifreTekrar.TabIndex = 7;
            this.lblSifreTekrar.Text = "Şifrenizi Tekrar Giriniz :";
            // 
            // txtSifreTekrar
            // 
            this.txtSifreTekrar.Location = new System.Drawing.Point(229, 213);
            this.txtSifreTekrar.Name = "txtSifreTekrar";
            this.txtSifreTekrar.Size = new System.Drawing.Size(138, 22);
            this.txtSifreTekrar.TabIndex = 6;
            // 
            // btnKayitOnay
            // 
            this.btnKayitOnay.Location = new System.Drawing.Point(566, 368);
            this.btnKayitOnay.Name = "btnKayitOnay";
            this.btnKayitOnay.Size = new System.Drawing.Size(138, 34);
            this.btnKayitOnay.TabIndex = 8;
            this.btnKayitOnay.Text = "Kayıt Ol";
            this.btnKayitOnay.UseVisualStyleBackColor = true;
            this.btnKayitOnay.Click += new System.EventHandler(this.btnKayitOnay_Click);
            // 
            // lblGuvenlik
            // 
            this.lblGuvenlik.AutoSize = true;
            this.lblGuvenlik.Location = new System.Drawing.Point(15, 34);
            this.lblGuvenlik.Name = "lblGuvenlik";
            this.lblGuvenlik.Size = new System.Drawing.Size(210, 16);
            this.lblGuvenlik.TabIndex = 9;
            this.lblGuvenlik.Text = "En yakın arkadaşınızın ismi nedir ?";
            // 
            // gBoxGuvenlik
            // 
            this.gBoxGuvenlik.Controls.Add(this.txtGuvenlik);
            this.gBoxGuvenlik.Controls.Add(this.lblGuvenlik);
            this.gBoxGuvenlik.Location = new System.Drawing.Point(47, 286);
            this.gBoxGuvenlik.Name = "gBoxGuvenlik";
            this.gBoxGuvenlik.Size = new System.Drawing.Size(320, 139);
            this.gBoxGuvenlik.TabIndex = 10;
            this.gBoxGuvenlik.TabStop = false;
            this.gBoxGuvenlik.Text = "Güvenlik Sorusu";
            // 
            // txtGuvenlik
            // 
            this.txtGuvenlik.Location = new System.Drawing.Point(18, 82);
            this.txtGuvenlik.Multiline = true;
            this.txtGuvenlik.Name = "txtGuvenlik";
            this.txtGuvenlik.Size = new System.Drawing.Size(207, 34);
            this.txtGuvenlik.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBoxGuvenlik);
            this.Controls.Add(this.btnKayitOnay);
            this.Controls.Add(this.lblSifreTekrar);
            this.Controls.Add(this.txtSifreTekrar);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblSifreSec);
            this.Controls.Add(this.lblKullaniciAdiSec);
            this.Controls.Add(this.txtSifreBelirle);
            this.Controls.Add(this.txtUsernameBelirle);
            this.Controls.Add(this.lblKayitHg);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.gBoxGuvenlik.ResumeLayout(false);
            this.gBoxGuvenlik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKayitHg;
        private System.Windows.Forms.TextBox txtUsernameBelirle;
        private System.Windows.Forms.TextBox txtSifreBelirle;
        private System.Windows.Forms.Label lblKullaniciAdiSec;
        private System.Windows.Forms.Label lblSifreSec;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblSifreTekrar;
        private System.Windows.Forms.TextBox txtSifreTekrar;
        private System.Windows.Forms.Button btnKayitOnay;
        private System.Windows.Forms.Label lblGuvenlik;
        private System.Windows.Forms.GroupBox gBoxGuvenlik;
        private System.Windows.Forms.TextBox txtGuvenlik;
    }
}