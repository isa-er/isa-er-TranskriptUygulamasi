using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Npgsql;

namespace BİL203_Ödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;" +
                                        "Database=deneme;User Id=postgres;Password=1313");


        public void tabloGoster(string sorgu)
        {
            baglanti.Open();
            NpgsqlCommand komut = new NpgsqlCommand();
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            komut.CommandText = sorgu;
            NpgsqlDataReader dataReader = komut.ExecuteReader();

            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }


        private void btnGoster_Click(object sender, EventArgs e)
        {
            tabloGoster("select * from ders order by dönemi");
            baglanti.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();  // ders guncelleme formu
            form3.Show();
            this.Hide();
        }

        private void ekleme_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();  // ders ekleme formu
            form2.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();  // ders silme formu
            form4.Show();
            this.Hide();
        }

        private void btnTranskript_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(); // transkript formu
            form5.Show();
            this.Hide();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
                          
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
