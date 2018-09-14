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
    public partial class yeni_kullanici : Form
    {
        public yeni_kullanici()
        {
            InitializeComponent();
        }

        private void btn_kayit_Click(object sender, EventArgs e)
        {
            try
            {
                //Baglanti tanimlanir
                SqlConnection connect = new SqlConnection("server=10.2.8.72\\SQLEXPRESS;user=sa;pwd=1234;database=Users");
                //Baglanti acilir
                SqlCommand query = new SqlCommand();
                query.Connection = connect;
                query.CommandText = "INSERT INTO kullanıcılar(kullanici_name,kullanici_sfr,kullanici_ad,kullanici_soyad,kullanici_email) VALUES(@k_name,@k_sifre,@k_adi,@k_soyad,@k_mail)";


                query.Parameters.Add("@k_name", SqlDbType.NChar);
                query.Parameters["@k_name"].Value = txt_user.Text.Trim();

                query.Parameters.Add("@k_sifre", SqlDbType.NVarChar);
                query.Parameters["@k_sifre"].Value = txt_sfr.Text.Trim();

                query.Parameters.Add("@k_adi", SqlDbType.NVarChar);
                query.Parameters["@k_adi"].Value = txt_ad.Text.Trim();

                query.Parameters.Add("@k_soyad", SqlDbType.NVarChar);
                query.Parameters["@k_soyad"].Value = txt_soyad.Text.Trim();

                query.Parameters.Add("@k_mail",SqlDbType.NVarChar);
                query.Parameters["@k_mail"].Value = txt_mail.Text.Trim();
               
                connect.Open();
                query.ExecuteNonQuery();//Calistir ve bir deger döndürme
                
                connect.Close();
                txt_ad.Clear();
                txt_mail.Clear();
                txt_sfr.Clear();
                txt_soyad.Clear();
                txt_user.Clear();
                MessageBox.Show("Kaydınız Gerçekleştirilmiştir...");
                ana_menu menu = new ana_menu();
                menu.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
  
        private void btn_geri_Click(object sender, EventArgs e)
        {
            ana_menu menu = new ana_menu();
            menu.Show();
            this.Hide();
        }

        private void yeni_kullanici_Load(object sender, EventArgs e)
        {

        }
    }
}
