using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BİL203_Ödev2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("Server=localhost;Port=5432;Database=deneme;User Id=postgres;Password=1313");


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



        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnGuncellemeYonlendir_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void btnTranskriptYonlendir_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void btnDersiGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand y = new NpgsqlCommand();
            y.Connection = baglanti;


            y.Parameters.AddWithValue("@x", txtHangiDersKodu.Text);
            y.CommandType = CommandType.Text;
            y.CommandText = "select * from ders where ders_kodu=@x";

            NpgsqlDataReader dataReader = y.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            y.Dispose();
            baglanti.Close();
        }

        private void btnDersiSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut_sil = new NpgsqlCommand();
            komut_sil.Connection = baglanti;
            komut_sil.Parameters.AddWithValue("@hangi_ders_kodu", txtHangiDersKodu.Text);

            komut_sil.CommandType = CommandType.Text;
            komut_sil.CommandText = "delete from ders where ders_kodu = @hangi_ders_kodu";

            NpgsqlDataReader dataReader = komut_sil.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_sil.Dispose();
            baglanti.Close();
            MessageBox.Show(txtHangiDersKodu.Text + " Kodlu Ders Silinmiştir! ");
            tabloGoster("select * from ders");
            txtHangiDersKodu.Text = "";
            txtHangiDersKodu.Focus();
        }

        private void btnIptalEt_Click(object sender, EventArgs e)
        {
            txtHangiDersKodu.Text = "";
            txtHangiDersKodu.Focus();
            MessageBox.Show("Silme İşlemi İptal Edildi");
        }
    }
}
