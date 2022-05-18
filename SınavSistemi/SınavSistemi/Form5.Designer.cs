namespace SınavSistemi
{
    partial class Form5
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
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.btnSoruEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioBtnA = new System.Windows.Forms.RadioButton();
            this.radioBtnB = new System.Windows.Forms.RadioButton();
            this.radioBtnC = new System.Windows.Forms.RadioButton();
            this.radioBtnD = new System.Windows.Forms.RadioButton();
            this.btnSoruGoster = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSoru
            // 
            this.txtSoru.Location = new System.Drawing.Point(27, 118);
            this.txtSoru.Multiline = true;
            this.txtSoru.Name = "txtSoru";
            this.txtSoru.Size = new System.Drawing.Size(613, 234);
            this.txtSoru.TabIndex = 0;
            // 
            // btnSoruEkle
            // 
            this.btnSoruEkle.Location = new System.Drawing.Point(613, 404);
            this.btnSoruEkle.Name = "btnSoruEkle";
            this.btnSoruEkle.Size = new System.Drawing.Size(159, 55);
            this.btnSoruEkle.TabIndex = 1;
            this.btnSoruEkle.Text = "Soru Ekle";
            this.btnSoruEkle.UseVisualStyleBackColor = true;
            this.btnSoruEkle.Click += new System.EventHandler(this.btnSoruEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(170, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "SORU EKLEME PANELİNE HOŞ GELDİNİZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioBtnD);
            this.groupBox1.Controls.Add(this.radioBtnC);
            this.groupBox1.Controls.Add(this.radioBtnB);
            this.groupBox1.Controls.Add(this.radioBtnA);
            this.groupBox1.Location = new System.Drawing.Point(667, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(105, 234);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şıklar";
            // 
            // radioBtnA
            // 
            this.radioBtnA.AutoSize = true;
            this.radioBtnA.Location = new System.Drawing.Point(19, 48);
            this.radioBtnA.Name = "radioBtnA";
            this.radioBtnA.Size = new System.Drawing.Size(37, 20);
            this.radioBtnA.TabIndex = 0;
            this.radioBtnA.TabStop = true;
            this.radioBtnA.Text = "A";
            this.radioBtnA.UseVisualStyleBackColor = true;
            // 
            // radioBtnB
            // 
            this.radioBtnB.AutoSize = true;
            this.radioBtnB.Location = new System.Drawing.Point(19, 88);
            this.radioBtnB.Name = "radioBtnB";
            this.radioBtnB.Size = new System.Drawing.Size(37, 20);
            this.radioBtnB.TabIndex = 1;
            this.radioBtnB.TabStop = true;
            this.radioBtnB.Text = "B";
            this.radioBtnB.UseVisualStyleBackColor = true;
            // 
            // radioBtnC
            // 
            this.radioBtnC.AutoSize = true;
            this.radioBtnC.Location = new System.Drawing.Point(19, 130);
            this.radioBtnC.Name = "radioBtnC";
            this.radioBtnC.Size = new System.Drawing.Size(37, 20);
            this.radioBtnC.TabIndex = 2;
            this.radioBtnC.TabStop = true;
            this.radioBtnC.Text = "C";
            this.radioBtnC.UseVisualStyleBackColor = true;
            // 
            // radioBtnD
            // 
            this.radioBtnD.AutoSize = true;
            this.radioBtnD.Location = new System.Drawing.Point(19, 174);
            this.radioBtnD.Name = "radioBtnD";
            this.radioBtnD.Size = new System.Drawing.Size(38, 20);
            this.radioBtnD.TabIndex = 3;
            this.radioBtnD.TabStop = true;
            this.radioBtnD.Text = "D";
            this.radioBtnD.UseVisualStyleBackColor = true;
            // 
            // btnSoruGoster
            // 
            this.btnSoruGoster.Location = new System.Drawing.Point(27, 404);
            this.btnSoruGoster.Name = "btnSoruGoster";
            this.btnSoruGoster.Size = new System.Drawing.Size(129, 55);
            this.btnSoruGoster.TabIndex = 4;
            this.btnSoruGoster.Text = "Soruları Göster";
            this.btnSoruGoster.UseVisualStyleBackColor = true;
            this.btnSoruGoster.Click += new System.EventHandler(this.btnSoruGoster_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 533);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(681, 186);
            this.dataGridView1.TabIndex = 5;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 841);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSoruGoster);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSoruEkle);
            this.Controls.Add(this.txtSoru);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.Button btnSoruEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioBtnD;
        private System.Windows.Forms.RadioButton radioBtnC;
        private System.Windows.Forms.RadioButton radioBtnB;
        private System.Windows.Forms.RadioButton radioBtnA;
        private System.Windows.Forms.Button btnSoruGoster;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}