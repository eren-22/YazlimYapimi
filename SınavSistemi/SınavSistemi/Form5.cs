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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        guvenlikEntities baglanti = new guvenlikEntities();        

        //List<SORU> sorular;
        private void btnSoruEkle_Click(object sender, EventArgs e)
        {

            TBL_SORU sorular = new TBL_SORU();  //tblogrenci classından yeni türetme
           
            sorular.SORULAR = txtSoru.Text;
                      
            sorular.CEVAPLAR = "A";

            baglanti.TBL_SORU.Add(sorular);            
            

            baglanti.SaveChanges();

            MessageBox.Show("Soru Tabloya Eklenmiştir ! ");

            txtSoru.Clear();
           

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void btnSoruGoster_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = baglanti.TBL_SORU.ToList();
        }
    }
}
