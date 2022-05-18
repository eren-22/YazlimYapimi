namespace SınavSistemi
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblSinav = new System.Windows.Forms.Label();
            this.lsBoxSorular = new System.Windows.Forms.ListBox();
            this.btnSonrakiSoru = new System.Windows.Forms.Button();
            this.btnSinavBasla = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDk = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(91, 636);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1012, 295);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblSinav
            // 
            this.lblSinav.AutoSize = true;
            this.lblSinav.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSinav.Location = new System.Drawing.Point(415, 69);
            this.lblSinav.Name = "lblSinav";
            this.lblSinav.Size = new System.Drawing.Size(285, 25);
            this.lblSinav.TabIndex = 1;
            this.lblSinav.Text = "Sınav Paneline Hoş Geldiniz";
            // 
            // lsBoxSorular
            // 
            this.lsBoxSorular.FormattingEnabled = true;
            this.lsBoxSorular.ItemHeight = 16;
            this.lsBoxSorular.Location = new System.Drawing.Point(275, 127);
            this.lsBoxSorular.Name = "lsBoxSorular";
            this.lsBoxSorular.Size = new System.Drawing.Size(569, 260);
            this.lsBoxSorular.TabIndex = 2;
            // 
            // btnSonrakiSoru
            // 
            this.btnSonrakiSoru.Location = new System.Drawing.Point(727, 429);
            this.btnSonrakiSoru.Name = "btnSonrakiSoru";
            this.btnSonrakiSoru.Size = new System.Drawing.Size(117, 32);
            this.btnSonrakiSoru.TabIndex = 3;
            this.btnSonrakiSoru.Text = "Sonraki Soru";
            this.btnSonrakiSoru.UseVisualStyleBackColor = true;
            // 
            // btnSinavBasla
            // 
            this.btnSinavBasla.Location = new System.Drawing.Point(53, 247);
            this.btnSinavBasla.Name = "btnSinavBasla";
            this.btnSinavBasla.Size = new System.Drawing.Size(132, 42);
            this.btnSinavBasla.TabIndex = 4;
            this.btnSinavBasla.Text = "Sınava Başla";
            this.btnSinavBasla.UseVisualStyleBackColor = true;
            this.btnSinavBasla.Click += new System.EventHandler(this.btnSinavBasla_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDk
            // 
            this.lblDk.AutoSize = true;
            this.lblDk.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDk.Location = new System.Drawing.Point(1037, 32);
            this.lblDk.Name = "lblDk";
            this.lblDk.Size = new System.Drawing.Size(35, 20);
            this.lblDk.TabIndex = 5;
            this.lblDk.Text = "_ _";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(1078, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = ":";
            // 
            // lblSn
            // 
            this.lblSn.AutoSize = true;
            this.lblSn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSn.Location = new System.Drawing.Point(1099, 32);
            this.lblSn.Name = "lblSn";
            this.lblSn.Size = new System.Drawing.Size(35, 20);
            this.lblSn.TabIndex = 7;
            this.lblSn.Text = "_ _";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1219, 943);
            this.Controls.Add(this.lblSn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDk);
            this.Controls.Add(this.btnSinavBasla);
            this.Controls.Add(this.btnSonrakiSoru);
            this.Controls.Add(this.lsBoxSorular);
            this.Controls.Add(this.lblSinav);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblSinav;
        private System.Windows.Forms.ListBox lsBoxSorular;
        private System.Windows.Forms.Button btnSonrakiSoru;
        private System.Windows.Forms.Button btnSinavBasla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSn;
    }
}