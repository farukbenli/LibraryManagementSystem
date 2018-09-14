namespace kütüphane
{
    partial class Kullanici
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.profil = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.alinanlar = new System.Windows.Forms.TabPage();
            this.talep = new System.Windows.Forms.TabPage();
            this.arama = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btn_ara = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.text_ad = new System.Windows.Forms.TextBox();
            this.text_soyad = new System.Windows.Forms.TextBox();
            this.text_kadi = new System.Windows.Forms.TextBox();
            this.text_sfr = new System.Windows.Forms.TextBox();
            this.text_mail = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.profil.SuspendLayout();
            this.arama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.profil);
            this.tabControl1.Controls.Add(this.alinanlar);
            this.tabControl1.Controls.Add(this.talep);
            this.tabControl1.Controls.Add(this.arama);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(75, 10);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(893, 364);
            this.tabControl1.TabIndex = 0;
            // 
            // profil
            // 
            this.profil.AutoScroll = true;
            this.profil.BackColor = System.Drawing.Color.Transparent;
            this.profil.Controls.Add(this.text_mail);
            this.profil.Controls.Add(this.text_sfr);
            this.profil.Controls.Add(this.text_kadi);
            this.profil.Controls.Add(this.text_soyad);
            this.profil.Controls.Add(this.text_ad);
            this.profil.Controls.Add(this.label5);
            this.profil.Controls.Add(this.label4);
            this.profil.Controls.Add(this.label3);
            this.profil.Controls.Add(this.label2);
            this.profil.Controls.Add(this.label1);
            this.profil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.profil.Location = new System.Drawing.Point(4, 36);
            this.profil.Margin = new System.Windows.Forms.Padding(5);
            this.profil.Name = "profil";
            this.profil.Padding = new System.Windows.Forms.Padding(3);
            this.profil.Size = new System.Drawing.Size(885, 324);
            this.profil.TabIndex = 0;
            this.profil.Text = "Profilim";
            this.profil.Click += new System.EventHandler(this.profil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "e - mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(233, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(236, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // alinanlar
            // 
            this.alinanlar.AutoScroll = true;
            this.alinanlar.BackColor = System.Drawing.Color.Transparent;
            this.alinanlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.alinanlar.Location = new System.Drawing.Point(4, 36);
            this.alinanlar.Name = "alinanlar";
            this.alinanlar.Padding = new System.Windows.Forms.Padding(3);
            this.alinanlar.Size = new System.Drawing.Size(885, 324);
            this.alinanlar.TabIndex = 1;
            this.alinanlar.Text = "Aldığım Kitaplar";
            // 
            // talep
            // 
            this.talep.AutoScroll = true;
            this.talep.BackColor = System.Drawing.Color.Transparent;
            this.talep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.talep.Location = new System.Drawing.Point(4, 36);
            this.talep.Name = "talep";
            this.talep.Padding = new System.Windows.Forms.Padding(3);
            this.talep.Size = new System.Drawing.Size(885, 324);
            this.talep.TabIndex = 2;
            this.talep.Text = "Talep Ettiklerim";
            // 
            // arama
            // 
            this.arama.AutoScroll = true;
            this.arama.BackColor = System.Drawing.Color.Transparent;
            this.arama.Controls.Add(this.dataGridView1);
            this.arama.Controls.Add(this.radioButton2);
            this.arama.Controls.Add(this.radioButton1);
            this.arama.Controls.Add(this.btn_ara);
            this.arama.Controls.Add(this.txt_ad);
            this.arama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arama.Location = new System.Drawing.Point(4, 36);
            this.arama.Name = "arama";
            this.arama.Padding = new System.Windows.Forms.Padding(3);
            this.arama.Size = new System.Drawing.Size(885, 324);
            this.arama.TabIndex = 3;
            this.arama.Text = "Katalog Tarama";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(174, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 267);
            this.dataGridView1.TabIndex = 6;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 184);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(113, 20);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Yazara Göre";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 119);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(92, 20);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(7, 261);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(125, 34);
            this.btn_ara.TabIndex = 3;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(7, 41);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(125, 22);
            this.txt_ad.TabIndex = 2;
            // 
            // text_ad
            // 
            this.text_ad.Location = new System.Drawing.Point(462, 53);
            this.text_ad.Name = "text_ad";
            this.text_ad.ReadOnly = true;
            this.text_ad.Size = new System.Drawing.Size(100, 22);
            this.text_ad.TabIndex = 10;
            // 
            // text_soyad
            // 
            this.text_soyad.Location = new System.Drawing.Point(462, 94);
            this.text_soyad.Name = "text_soyad";
            this.text_soyad.ReadOnly = true;
            this.text_soyad.Size = new System.Drawing.Size(100, 22);
            this.text_soyad.TabIndex = 11;
            // 
            // text_kadi
            // 
            this.text_kadi.Location = new System.Drawing.Point(462, 137);
            this.text_kadi.Name = "text_kadi";
            this.text_kadi.ReadOnly = true;
            this.text_kadi.Size = new System.Drawing.Size(100, 22);
            this.text_kadi.TabIndex = 12;
            // 
            // text_sfr
            // 
            this.text_sfr.Location = new System.Drawing.Point(462, 177);
            this.text_sfr.Name = "text_sfr";
            this.text_sfr.ReadOnly = true;
            this.text_sfr.Size = new System.Drawing.Size(100, 22);
            this.text_sfr.TabIndex = 13;
            // 
            // text_mail
            // 
            this.text_mail.Location = new System.Drawing.Point(462, 219);
            this.text_mail.Name = "text_mail";
            this.text_mail.ReadOnly = true;
            this.text_mail.Size = new System.Drawing.Size(100, 22);
            this.text_mail.TabIndex = 14;
            // 
            // Kullanici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(933, 389);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kullanici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanici";
            this.Load += new System.EventHandler(this.Kullanici_Load);
            this.tabControl1.ResumeLayout(false);
            this.profil.ResumeLayout(false);
            this.profil.PerformLayout();
            this.arama.ResumeLayout(false);
            this.arama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage profil;
        private System.Windows.Forms.TabPage alinanlar;
        private System.Windows.Forms.TabPage talep;
        private System.Windows.Forms.TabPage arama;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox text_mail;
        private System.Windows.Forms.TextBox text_sfr;
        private System.Windows.Forms.TextBox text_kadi;
        private System.Windows.Forms.TextBox text_soyad;
        private System.Windows.Forms.TextBox text_ad;
    }
}