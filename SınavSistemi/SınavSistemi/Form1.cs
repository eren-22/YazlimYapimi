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
using System.Collections;

namespace SınavSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        guvenlikEntities baglanti = new guvenlikEntities();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string adminSifre = "1111";
            string adminUsername = "admin";
            
                List <Table_1> deneme;
               deneme = baglanti.Table_1.ToList();
            

            foreach (Table_1 kullanici in deneme)
            {
                     //kullanici.Username.ToString().Equals(txtUsername.Text) && kullanici.Password.ToString().Equals(txtPassword.Text);
                     string kullaniciAdi = kullanici.Username.ToString();
                     string user = txtUsername.Text;
                    
                     string kullaniciSifre = kullanici.Password.ToString();

                    /*MessageBox.Show(kullaniciAdi);
                    MessageBox.Show(user);*/

                     if(kullanici.Username.ToString()== txtUsername.Text && kullanici.Password.ToString() == txtPassword.Text)  
                     {                       
                         Form2 giris = new Form2();
                         giris.ShowDialog();
                        // MessageBox.Show(kullanici.Username.ToString());
                       
                     }
                     else
                     {
                         //MessageBox.Show("Girmedi");
                        // MessageBox.Show(kullanici.Username.ToString());                       

                     }

            }  
            
            if(txtUsername.Text == adminUsername && txtPassword.Text == adminSifre)
            {
                Form5 adminPanel = new Form5();
                adminPanel.ShowDialog();

            }

        }

        private void btnUnuttum_Click(object sender, EventArgs e)
        {
            Form4 unuttum = new Form4();    
            unuttum.ShowDialog();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            Form3 kayitOl = new Form3();
            kayitOl.ShowDialog();
        }

        private void btnShowUsers_Click(object sender, EventArgs e)
        {

            Form2 giris = new Form2();
            giris.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
