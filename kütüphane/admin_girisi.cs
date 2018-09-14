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
    public partial class admin_girisi : Form
    {
        public admin_girisi()
        {
            InitializeComponent();
            txt_user.Focus();
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            ana_menu menu = new ana_menu();
            menu.Show();
            this.Hide();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = null;
            SqlDataReader oku = null;
            try 
            {
                baglanti = new SqlConnection(@"server=10.2.8.72\SQLEXPRESS;user=sa;pwd=1234;database=Users;");
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * from admin where administrator='"+txt_user.Text +"' and a_sfr = '"+txt_sfr.Text +"'", baglanti);
                oku = komut.ExecuteReader();
                if(oku.Read() == true)
                {
                    MessageBox.Show("Hoşgeldiniz " + txt_user.Text);
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
    }
}
