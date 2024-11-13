using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace saglik_ocagi_otomasyon
{
    public partial class hastaGiris : Form
    {
        public hastaGiris()
        {
            InitializeComponent();

        }
        OleDbConnection baglant1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=0:\\saglikOcagi.accdb");
        OleDbConnection baglanti;
        OleDbCommand cmd;
        OleDbDataReader dr;


        private void giris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglant1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=0:\\saglikOcagi.accdb");

            string ad = txtHastaTC.Text;
            string sifre = this.txtHastaSifre.Text;
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=saglikOcagi.accdb");
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "Select * from kayitli_hasta where StrComp(h_TC_no,'" + txtHastaTC.Text + "',0)=0 and StrComp(h_sifre,'" + this.txtHastaSifre.Text + "',0)=0";

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                doktorListe f2 = new doktorListe ();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış");
            }

            baglanti.Close();
        }

        private void cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hastaGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
