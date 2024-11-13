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
    public partial class hastaListesi : Form
    {
        public hastaListesi()
        {
            InitializeComponent();
            
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source = " + Application.StartupPath + "\\saglikOcagi.accdb");
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        // Kişileri listelemek için metot oluşturuyoruz.
        void griddoldur()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=saglikOcagi.accdb");
            da = new OleDbDataAdapter("Select *from hasta_kayit_tablosu", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "hasta_kayit_tablosu");
            dataGridView1.DataSource = ds.Tables["hasta_kayit_tablosu"];
            baglanti.Close();
        }

        void KisiListele()
        {
            baglanti = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=saglikOcagi.accdb");
            baglanti.Open();
            da = new OleDbDataAdapter("Select *From hasta_kayit_tablosu", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sil_Click(object sender, EventArgs e) //SİLME BUTONU
        {
            cmd = new OleDbCommand();
            baglanti.Open();
            cmd.Connection = baglanti;
            cmd.CommandText = "delete from hasta_kayit_tablosu where TC_no" + tcNo.Text + "";
            cmd.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
        }

        private void hastaListesi_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
    }
}
