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
    public partial class sifre_al : Form
    {
        ana_menu menu = new ana_menu();
        public sifre_al()
        {
            InitializeComponent();
            SqlConnection baglanti = new SqlConnection();
            baglanti.ConnectionString = "server=10.2.8.203\\SQLEXPRESS,user=sa,pwd=1234,database=Users";
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            
            menu.Show();
            this.Hide();
        }

        private void btn_sfr_Click(object sender, EventArgs e)
        {
            txt_adi.Focus();
            MessageBox.Show("Yeni Şifre");// yeni şifreyi gösterecekk...
            menu.Show();
            this.Hide();
        }

        private void sifre_al_Load(object sender, EventArgs e)
        {

        }

       
    }
}
