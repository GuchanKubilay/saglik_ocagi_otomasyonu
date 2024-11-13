using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saglik_ocagi_otomasyon
{
    public partial class doktorGirisi : Form
    {
        public doktorGirisi()
        {
            InitializeComponent();
        }
        private void txtkullaniciadi_Click(object sender, EventArgs e)
        {
            txtkullaniciadi.Text = ""; 
        }

        private void txtsifre_Click(object sender, EventArgs e)
        {
            txtsifre.Text = ""; 
        }

        int hak = 3;

        private void giris_Click(object sender, EventArgs e)
        {
            if (txtkullaniciadi.Text == "" || txtsifre.Text == "")
            {
                MessageBox.Show("Kullanıcı adı ve/veya şifre boş geçilemez", "Uyarı"); 
            }
            else
            {
                if (txtkullaniciadi.Text == "admin" && txtsifre.Text == "123456")
                {
                    hastaListesi form3 = new hastaListesi(); 
                    form3.Show();  
                    this.Hide();

                }
                else
                {
                    hak--;
                    MessageBox.Show("Kullanıcı adı ve/veya şifre yanlış.Kalan hakkınız=" + hak, "Uyarı2");
                    if (hak == 0)
                    {
                        Application.Exit(); 
                    }
                }
            }

        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void doktorGirisi_Load(object sender, EventArgs e)
        {

        }
    }
}
