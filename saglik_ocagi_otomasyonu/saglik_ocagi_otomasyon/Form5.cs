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
    public partial class doktorListe : Form
    {
        public doktorListe()
        {
            InitializeComponent();
            griddoldur();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source = " + Application.StartupPath + "\\saglikOcagi.accdb");

        private void listele() // Bu listele methodu ile veritabanında yer alan verileri form açıldığında direk gözükmesini sağlıyoruz.
        {
            try
            {
                baglanti.Open();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from doktorlar", baglanti);
                DataSet hafiza = new DataSet();
                listele.Fill(hafiza);
                dataGridView1.DataSource = hafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message);
                baglanti.Close();
            }
        }
        void griddoldur()
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void doktorListe_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
