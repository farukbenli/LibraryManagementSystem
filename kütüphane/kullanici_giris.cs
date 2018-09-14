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
    public partial class kullanici_giris : Form
    {
        //public static string zehra = "kartal";
        public static string ad,soyad,k_ad,sifre,email;
        
        public kullanici_giris()
        {
            InitializeComponent();
            
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            ana_menu menu = new ana_menu();
            menu.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            gecis(); 
        }
        private void gecis()
        {
            SqlConnection baglanti = null;
            SqlDataReader oku = null;
            
            try
            {
                baglanti = new SqlConnection(@"server=10.2.8.72\SQLEXPRESS;user=sa;pwd=1234;database=Users;");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * from kullanıcılar where kullanici_name='" + txt_user.Text + "' and kullanici_sfr= '" + txt_sfr.Text + "' ", baglanti);

                oku = komut.ExecuteReader();
                if (oku.Read() == true )
                {
                    ad = oku["kullanici_ad"].ToString();
                    soyad = oku["kullanici_soyad"].ToString();
                    k_ad = oku["kullanici_name"].ToString();
                    sifre = oku["kullanici_sfr"].ToString();
                    email = oku["kullanici_email"].ToString();
                    MessageBox.Show("Hoşgeldiniz " + txt_user.Text );
                    Kullanici kullanici = new Kullanici();
                    kullanici.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız.");
                    txt_user.Clear();
                    txt_sfr.Clear();
                    txt_user.Focus();
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

        private void txt_sfr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                gecis();
            }
        }

        private void kullanici_giris_Load(object sender, EventArgs e)
        {
            
        }

      
    }
}
