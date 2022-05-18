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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }


        guvenlikEntities baglanti = new guvenlikEntities();

        private void btnKayitOnay_Click(object sender, EventArgs e)
        {
            Table_1 users = new Table_1();
                       

            if (txtGuvenlik.Text != "" && txtSifreBelirle.Text != "" && txtSifreTekrar.Text != "" && txtUsernameBelirle.Text != "") 
            { 
                if(txtSifreTekrar.Text == txtSifreBelirle.Text)
                {

                    users.Username = txtUsernameBelirle.Text;
                    users.Password = txtSifreBelirle.Text;
                    users.Security = txtGuvenlik.Text;
    

                    if(checkBox1.Checked == true) 
                    { 
                                                         
                        baglanti.Table_1.Add(users);
                        baglanti.SaveChanges();
                    
                    
                        MessageBox.Show("Kullanıcı Kaydınız Başarı İle Gerçekleşmiştir !");
                

                        txtSifreBelirle.Clear();
                        txtSifreTekrar.Clear();
                        txtUsernameBelirle.Clear();
                    
                    }
                    else 
                    {
                        MessageBox.Show("Lütfen Bilgilerinizin Doğruluğunu Onaylayınız");
                    }

                }

                else
                {
                    MessageBox.Show("Lütfen Belirlediğiniz Şifreyi Doğru Giriniz");
                }
            }
                    
                       
            else
            {
                MessageBox.Show("Lütfen Tüm Bilgilerinizi Eksiksiz Bİr Şekilde Doldurunuz");
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
