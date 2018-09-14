using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace kütüphane
{
    public partial class Kullanici : Form
    {
        SqlConnection baglanti = null;
        SqlDataReader oku = null;
        
        public Kullanici()
        {
            InitializeComponent();
        }

        private void profil_Click(object sender, EventArgs e)
        {
           
            
            try
            {
                baglanti = new SqlConnection(@"server=10.2.8.72\SQLEXPRESS;user=sa;pwd=1234;database=Users;");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * from kullanıcılar where kullanici_name = and kullanici_sfr ", baglanti); 
                oku = komut.ExecuteReader();

                if (oku.Read() == true)
                {
                    MessageBox.Show("Hoşgeldiniz ");
                    Kullanici kullanici = new Kullanici();
                    kullanici.Show();
                    this.Hide();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oku != null)
                    oku.Close();
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void Kullanici_Load(object sender, EventArgs e)
        {
            //label1.Text = kullanici_giris.zehra;
            text_ad.Text = kullanici_giris.ad;
            text_soyad.Text = kullanici_giris.soyad;
            text_kadi.Text = kullanici_giris.k_ad;
            text_sfr.Text = kullanici_giris.sifre;
            text_mail.Text = kullanici_giris.email;

        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            SqlCommand komut;
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            string sorgu1 = "SELECT Kitap_Adı as [Kitap Adı],yazar_soyisim as [Yazar Ad], Yayınevi_isim as [Yayınevi isim] ,[aktif-pasif] FROM kitaplar INNER JOIN yazar ON kitaplar.yazar_id=yazar.yazar_id INNER JOIN yayınevi ON kitaplar.yayınevi_id=yayınevi.yayınevi_id WHERE Kitap_Adı like '%" + txt_ad.Text.Trim() + "%'";
            string sorgu2 = "SELECT Kitap_Adı as [Kitap Adı],yazar_soyisim as [Yazar Ad], Yayınevi_isim as [Yayınevi isim] ,[aktif-pasif] FROM kitaplar INNER JOIN yazar ON kitaplar.yazar_id=yazar.yazar_id INNER JOIN yayınevi ON kitaplar.yayınevi_id=yayınevi.yayınevi_id WHERE yazar_soyisim like '%" + txt_ad.Text.Trim() + "%'";
            try
            {
                baglanti = new SqlConnection(@"server=10.2.8.72\SQLEXPRESS;user=sa;pwd=1234;database=Users;");
                baglanti.Open();
                if (radioButton1.Checked == true)
                {
                    komut = new SqlCommand(sorgu1, baglanti);
                    adapter.SelectCommand = komut;
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }

                if (radioButton2.Checked == true)
                {
                    komut = new SqlCommand(sorgu2, baglanti);
                    adapter.SelectCommand = komut;
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (oku != null)
                    oku.Close();
                if (baglanti != null)
                    baglanti.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }        
    }
}
