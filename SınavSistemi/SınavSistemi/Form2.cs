using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SınavSistemi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        guvenlikEntities baglanti = new guvenlikEntities();


        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.Table_1.ToList();
        }
        
        private void btnSinavBasla_Click(object sender, EventArgs e)
        {
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 60 * 1000); // 10 mins
            MyTimer.Tick += new EventHandler(timer1_Tick);
            MyTimer.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Sınav Süreniz Sona Ermiştir ! ", "Sınav Ekranı Kapanacaktır.");
            this.Close();
        }
    }
}
