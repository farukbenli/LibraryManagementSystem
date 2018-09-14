using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace kütüphane
{
    public partial class ana_menu : Form
    {
        public ana_menu()
        {
            InitializeComponent();
        }

        private void btn_yeni_Click(object sender, EventArgs e)
        {
            yeni_kullanici yk = new yeni_kullanici();
            yk.Show();
            this.Hide();

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            admin_girisi admin = new admin_girisi();
            admin.Show();
            this.Hide();
        }

        private void btn_kullanici_Click(object sender, EventArgs e)
        {
            kullanici_giris user = new kullanici_giris();
            user.Show();
            this.Hide();

        }

        private void btn_sfr_Click(object sender, EventArgs e)
        {
            sifre_al sifre = new sifre_al();
            sifre.Show();
            this.Hide();
        }
    }
}
