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
    public partial class Form5 : Form
    {
        public Form5()
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

        public void tabloGoster2(string sorgu) // SADECE  1.SINIFTAKI VERILERI CEKMEK ICIN
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
                dataGridView2.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }

        public void tabloGoster3(string sorgu)  //SADECE  2.SINIFTAKI VERILERI CEKMEK ICIN
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
                dataGridView3.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }

        public void tabloGoster4(string sorgu) //SADECE  3.SINIFTAKI VERILERI CEKMEK ICIN
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
                dataGridView4.DataSource = dataTable;
            }
            komut.Dispose();
            baglanti.Close();
        }



        private void btnTranskriptShow_Click(object sender, EventArgs e)
        {

            // DONEMI 2021/1 VE 2021/2 YANI SADECE 1.SINIFIN VERILERI

            tabloGoster2("select ders_kodu,ders_adı,ders_kredi," +
               "harfnotu,case when harfnotu='AA' then 4 when harfnotu='BA' then" +
               " 3.5 when harfnotu='CB' then 2.5 when harfnotu='BB' then 3 when harfnotu='CC' then 2 when " +
               "harfnotu='DC' then 1.5 when harfnotu='DD' then 1 when harfnotu='FD'" +
               " then 0.5 when harfnotu='FF' then 0 when harfnotu='' then 0  end puan from ders" +
               "  where harfnotu is not null and dönemi='2021/1' or dönemi='2021/2' group by ders_kodu order by dönemi");

            double krediDonem1 = 0;

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                krediDonem1 += (Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value) *
                Convert.ToDouble(dataGridView2.Rows[i].Cells[4].Value));

            }
            
            double toplamKrediDonem1 = 0;
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                toplamKrediDonem1 += Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value);

            }
           
            double ganoDonem1 = krediDonem1 / toplamKrediDonem1;
            txtDonem1.Text = Math.Round(ganoDonem1, 3).ToString();





            // DONEMI 2022/1 VE 2022/2 YANI SADECE 2.SINIFIN VERILERI

            tabloGoster3("select ders_kodu,ders_adı,ders_kredi," +
               "harfnotu,case when harfnotu='AA' then 4 when harfnotu='BA' then" +
               " 3.5 when harfnotu='CB' then 2.5 when harfnotu='BB' then 3 when harfnotu='CC' then 2 when " +
               "harfnotu='DC' then 1.5 when harfnotu='DD' then 1 when harfnotu='FD'" +
               " then 0.5 when harfnotu='FF' then 0 when harfnotu='' then 0  end puan from ders" +
               "  where harfnotu is not null and dönemi='2021/1' or dönemi='2021/2' group by ders_kodu order by dönemi");

            double krediDonem2 = 0;

            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {
                    krediDonem2 += (Convert.ToDouble(dataGridView3.Rows[i].Cells[2].Value) *
                Convert.ToDouble(dataGridView3.Rows[i].Cells[4].Value));

            }

            double toplamKrediDonem2 = 0;
            for (int i = 0; i < dataGridView3.RowCount; i++)
            {
                toplamKrediDonem2 += Convert.ToDouble(dataGridView3.Rows[i].Cells[2].Value);

            }

            double ganoDonem2 = krediDonem2 / toplamKrediDonem2;
            txtDonem2.Text = Math.Round(ganoDonem2, 3).ToString();
           



            // DONEMI 2023/1 VE 2023/2 YANI SADECE 3.SINIFIN VERILERI
            tabloGoster4("select ders_kodu,ders_adı,ders_kredi," +
               "harfnotu,case when harfnotu='AA' then 4 when harfnotu='BA' then" +
               " 3.5 when harfnotu='CB' then 2.5 when harfnotu='BB' then 3 when harfnotu='CC' then 2 when " +
               "harfnotu='DC' then 1.5 when harfnotu='DD' then 1 when harfnotu='FD'" +
               " then 0.5 when harfnotu='FF' then 0 when harfnotu='' then 0  end puan from ders" +
               "  where harfnotu is not null and dönemi='2023/1'  or dönemi='2023/2' group by ders_kodu order by dönemi");

            double krediDonem3 = 0;

            for (int i = 0; i < dataGridView4.Rows.Count; i++)
            {
                krediDonem3 += (Convert.ToDouble(dataGridView4.Rows[i].Cells[2].Value) *
                Convert.ToDouble(dataGridView4.Rows[i].Cells[4].Value));

            }


            double toplamKrediDonem3 = 0;
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                toplamKrediDonem3 += Convert.ToDouble(dataGridView4.Rows[i].Cells[2].Value);

            }
           

            double ganoDonem3 = krediDonem3 / toplamKrediDonem3;
            txtDonem3.Text = Math.Round(ganoDonem3, 3).ToString();





            // GANO ICIN
            tabloGoster("select ders_kodu,ders_adı,ders_kredi," +
                "harfnotu,case when harfnotu='AA' then 4 when harfnotu='BA' then" +
                " 3.5 when harfnotu='CB' then 2.5 when harfnotu='BB' then 3 when harfnotu='CC' then 2 when " +
                "harfnotu='DC' then 1.5 when harfnotu='DD' then 1 when harfnotu='FD'" +
                " then 0.5 when harfnotu='FF' then 0 when harfnotu='' then 0  end puan from ders" +
                "  where harfnotu is not null group by ders_kodu order by dönemi");

            double krediToplam = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                    krediToplam += (Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value) *
                    Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value));

            }


            double toplamKredi = 0;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                toplamKredi += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);

            }
            txtkredi.Text = toplamKredi.ToString();


            double gano = krediToplam / toplamKredi;
            txtgano.Text = Math.Round(gano,3).ToString();

            txtders.Text = dataGridView1.RowCount.ToString();

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAnaMenu_Click(object sender, EventArgs e)
        {
            Form1 form4 = new Form1();
            form4.Show();
            this.Hide();
        }

        private void btnSilSayfasi_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}
