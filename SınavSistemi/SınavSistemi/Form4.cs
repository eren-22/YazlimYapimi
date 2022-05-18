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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        guvenlikEntities baglanti = new guvenlikEntities();


        private void lblUnuttum_Click(object sender, EventArgs e)
        {

        }

        private void txtSifreOgren_Click(object sender, EventArgs e)        //burada da arananUser in friendi ne eşitleme yapmadığımız için hata verir.
        {
            string arananUser = txtUsername.Text;                             
            var username = from item in baglanti.Table_1              
                           where item.Username.Contains(arananUser)           
                           select item;

            string arananFriend = txtFriend.Text;
            var password = from item in baglanti.Table_1
                           where item.Username.Contains(arananFriend)
                           select item;
            
            
            if(arananFriend.ToString().Equals(txtFriend.Text) &&  username.ToString().Equals(txtUsername.Text))
            {
                var sifre = from item in baglanti.Table_1
                            select new
                            {
                                item.Password,
                            };
                MessageBox.Show("Şifreniz : " , sifre.ToString());

            }
            //kullanici.Username.ToString().Equals(txtUsername.Text) && kullanici.Password.ToString().Equals(txtPassword.Text);
            else
            {
                MessageBox.Show("Sorulara Verilen Cevaplarınız Yanlış ! ");
            }

          
            
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
