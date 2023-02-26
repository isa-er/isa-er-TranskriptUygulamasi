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
    public partial class Form2 : Form
    {
        public Form2()
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

        private void btnGuncelleYonlendir_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(); //guncelleme formu
            form3.Show();
            this.Hide();
        }



        // hangi checkbox  isaretlenirse onu lblkredide tutuyoruz
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



        // textbox temizleme ve imlecin konumlanmasi
        public void txtTemizleyici()
        {

            mskdDersKodu.Text = "";
            txtDersAdı.Text = "";
            txtOgrUyeAdı.Text = "";
            txtHarfNotu.Text = "";
            txtDönemi.Text = "";
            mskdDersKodu.Focus();

        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            txtTemizleyici();
        }



        private void btnDersEkle_Click(object sender, EventArgs e)
        {

            if (mskdDersKodu.MaskFull) 
            {
                
                
            }
            else
            {
                MessageBox.Show("Lütfen Ders Kodunu Kontrol Ediniz");
                return;
            }

            if (txtDersAdı.Text==string.Empty)
            {
                MessageBox.Show("Ders Adı Boş");
                return;
            }

            if (kredi2.Checked==false&& kredi3.Checked==false && kredi4.Checked==false &&
                kredi5.Checked==false && kredi6.Checked==false)
            {
                MessageBox.Show("Kredi Boş Geçilemez");
                return;

            }


            if (akts2.Checked==false && akts3.Checked==false && akts4.Checked==false
                && akts5.Checked==false && akts6.Checked==false)
            {
                MessageBox.Show("AKTS Boş Geçilemez");
                return;

            }

            if (txtOgrUyeAdı.Text==string.Empty)
            {
                MessageBox.Show("Öğretim Üyesi Adı Boş");
                return;
            }

            if (txtDönemi.Text==string.Empty)
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
            NpgsqlCommand komut_ekle = new NpgsqlCommand();
            komut_ekle.Connection = baglanti;

            komut_ekle.Parameters.AddWithValue("@derskodu", mskdDersKodu.Text);
            komut_ekle.Parameters.AddWithValue("@adi", txtDersAdı.Text);
            komut_ekle.Parameters.AddWithValue("@kredi", Convert.ToDouble(lblkredi.Text));
            komut_ekle.Parameters.AddWithValue("@akts", Convert.ToInt32(lblakts.Text));
            komut_ekle.Parameters.AddWithValue("@ogruyeadi", txtOgrUyeAdı.Text);
            komut_ekle.Parameters.AddWithValue("@donem", txtDönemi.Text);
            komut_ekle.Parameters.AddWithValue("@harfnotu", txtHarfNotu.Text);


            komut_ekle.CommandType = CommandType.Text;
            komut_ekle.CommandText = "insert into ders (ders_kodu, ders_adı, ders_kredi, ders_akts," +
            " ogruyeadsoyad,dönemi,harfnotu) values (@derskodu, @adi, @kredi, @akts, @ogruyeadi,@donem,@harfnotu)";

            NpgsqlDataReader dataReader = komut_ekle.ExecuteReader();
            if (dataReader.HasRows)
            {
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataGridView1.DataSource = dataTable;
            }
            komut_ekle.Dispose();
            baglanti.Close();

            MessageBox.Show(mskdDersKodu.Text + " Kodlu Ders Başarılı Bir Şekilde Eklendi");

            tabloGoster("select * from ders order by dönemi");
            baglanti.Close();

            txtTemizleyici();


        }

        private void txtDersKodu_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

           


        }
    }
}
