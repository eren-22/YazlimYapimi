namespace SınavSistemi
{
    partial class Form4
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
            this.lblUnuttum = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFriend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSifreOgren = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUnuttum
            // 
            this.lblUnuttum.AutoSize = true;
            this.lblUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnuttum.Location = new System.Drawing.Point(186, 83);
            this.lblUnuttum.Name = "lblUnuttum";
            this.lblUnuttum.Size = new System.Drawing.Size(370, 25);
            this.lblUnuttum.TabIndex = 0;
            this.lblUnuttum.Text = "Şifre Öğrenme Paneline Hoş Geldiniz";
            this.lblUnuttum.Click += new System.EventHandler(this.lblUnuttum_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(61, 199);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(146, 16);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Kullanıcı Adınızı Giriniz : ";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(471, 193);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(189, 22);
            this.txtUsername.TabIndex = 3;
            // 
            // txtFriend
            // 
            this.txtFriend.Location = new System.Drawing.Point(471, 247);
            this.txtFriend.Name = "txtFriend";
            this.txtFriend.Size = new System.Drawing.Size(189, 22);
            this.txtFriend.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(371, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Güvenlik Sorusu Olarak En Yakın Arkadaşınızın İsmini Giriniz : ";
            // 
            // txtSifreOgren
            // 
            this.txtSifreOgren.Location = new System.Drawing.Point(266, 348);
            this.txtSifreOgren.Name = "txtSifreOgren";
            this.txtSifreOgren.Size = new System.Drawing.Size(166, 39);
            this.txtSifreOgren.TabIndex = 6;
            this.txtSifreOgren.Text = "Şifre Öğren";
            this.txtSifreOgren.UseVisualStyleBackColor = true;
            this.txtSifreOgren.Click += new System.EventHandler(this.txtSifreOgren_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSifreOgren);
            this.Controls.Add(this.txtFriend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblUnuttum);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUnuttum;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFriend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button txtSifreOgren;
    }
}