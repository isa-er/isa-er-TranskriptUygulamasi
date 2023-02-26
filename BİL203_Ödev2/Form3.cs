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
    public partial class Form3 : Form
    {
        public Form3()
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

        private void btnEklemeYonlendir_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void btnSilmeYonlendir_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void btnDersGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand y = new NpgsqlCommand();
            y.Connection = baglanti;


            y.Parameters.AddWithValue("@x", txtHangiDers.Text);
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {


            if (mskdDersKodu.MaskFull)
            {


            }
            else
            {
                MessageBox.Show("Lütfen Ders Kodunu Kontrol Ediniz");
                return;
            }

            if (txtDersAdi.Text == string.Empty)
            {
                MessageBox.Show("Ders Adı Boş");
                return;
            }

            if (kredi2.Checked == false && kredi3.Checked == false && kredi4.Checked == false &&
                kredi5.Checked == false && kredi6.Checked == false)
            {
                MessageBox.Show("Kredi Boş Geçilemez");
                return;

            }


            if (akts2.Checked == false && akts3.Checked == false && akts4.Checked == false
                && akts5.Checked == false && akts6.Checked == false)
            {
                MessageBox.Show("AKTS Boş Geçilemez");
                return;

            }

            if (txtOgrUyeAdi.Text == string.Empty)
            {
                MessageBox.Show("Öğretim Üyesi Adı Boş");
                return;
            }

            if (txtDönemi.Text == string.Empty)
            {
                MessageBox.Show("Dönem Seçiniz");

                return;
            }

            if (txtHarfNotu.Text == string.Empty)
            {
                MessageBox.Show("Harf Notu Seçiniz");

                return;
            }




            baglanti.Open();
            NpgsqlCommand komut_guncelle = new NpgsqlCommand();
            komut_guncelle.Connection = baglanti;


            komut_guncelle.Parameters.AddWithValue("@derskodu", mskdDersKodu.Text);
            komut_guncelle.Parameters.AddWithValue("@dersadi", txtDersAdi.Text);
            komut_guncelle.Parameters.AddWithValue("@derskredi", Convert.ToDouble(lblkredi.Text));
            komut_guncelle.Parameters.AddWithValue("@dersakts", Convert.ToInt32(lblakts.Text));
            komut_guncelle.Parameters.AddWithValue("@txtogruyead", txtOgrUyeAdi.Text);
            komut_guncelle.Parameters.AddWithValue("@txtdonemi", txtDönemi.Text);
            komut_guncelle.Parameters.AddWithValue("@txtharfnotu", txtHarfNotu.Text);
            komut_guncelle.Parameters.AddWithValue("@txtHangiDers", txtHangiDers.Text);

            komut_guncelle.CommandType = CommandType.Text;
            komut_guncelle.CommandText = "update ders set ders_kodu=@derskodu, ders_adı=@dersadi," +
                " ders_kredi=@derskredi, ders_akts= @dersakts, ogruyeadsoyad=@txtogruyead ," +
                "dönemi=@txtdonemi,harfnotu=@txtharfnotu where ders_kodu = @txtHangiDers";
            NpgsqlDataReader dataReader = komut_guncelle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_guncelle.Dispose();
            baglanti.Close();
            MessageBox.Show(txtHangiDers.Text + " Kodlu Ders Güncellenmiştir! ");
            tabloGoster("select * from ders");

            txtTemizleyici();    
            txtHangiDers.Focus();

           
        }


        // bilgileri db den cekiyor, kredi ve akts checkbox oldugu icin otomatik doldurmuyor
        private void btnOtoDoldur_Click(object sender, EventArgs e)
        {
            int s = dataGridView1.SelectedCells[0].RowIndex;
            mskdDersKodu.Text = dataGridView1.Rows[s].Cells[0].Value.ToString();
            txtDersAdi.Text = dataGridView1.Rows[s].Cells[1].Value.ToString();
            //kredi2.Text = dataGridView1.Rows[s].Cells[2].Value.ToString();
            //akts2.Text = dataGridView1.Rows[s].Cells[3].Value.ToString();
            txtOgrUyeAdi.Text = dataGridView1.Rows[s].Cells[4].Value.ToString();
            txtDönemi.Text = dataGridView1.Rows[s].Cells[5].Value.ToString();
            txtHarfNotu.Text = dataGridView1.Rows[s].Cells[6].Value.ToString();
        }


        private void kredi2_CheckedChanged(object sender, EventArgs e)
        {
            lblkredi.Text = kredi2.Text;

        }

        private void kredi3_CheckedChanged(object sender, EventArgs e)
        {
            lblkredi.Text = kredi3.Text;
        }

        private void kredi4_CheckedChanged(object sender, EventArgs e)
        {
            lblkredi.Text = kredi4.Text;

        }

        private void kredi5_CheckedChanged(object sender, EventArgs e)
        {
            lblkredi.Text = kredi5.Text;
        }

        private void kredi6_CheckedChanged(object sender, EventArgs e)
        {
            lblkredi.Text = kredi6.Text;
        }

        private void akts2_CheckedChanged(object sender, EventArgs e)
        {
            lblakts.Text = akts2.Text;
        }

        private void akts3_CheckedChanged(object sender, EventArgs e)
        {
            lblakts.Text = akts3.Text;
        }

        private void akts4_CheckedChanged(object sender, EventArgs e)
        {
            lblakts.Text = akts4.Text;
        }

        private void akts5_CheckedChanged(object sender, EventArgs e)
        {
            lblakts.Text = akts5.Text;
        }

        private void akts6_CheckedChanged(object sender, EventArgs e)
        {
            lblakts.Text = akts6.Text;
        }

        public void txtTemizleyici()
        {
            
            mskdDersKodu.Text = "";
            txtDersAdi.Text = "";
            txtOgrUyeAdi.Text = "";
            txtHarfNotu.Text = "";
            txtDönemi.Text = "";

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtTemizleyici();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        

        

        private void txtHarfNotu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

      
    }
}
