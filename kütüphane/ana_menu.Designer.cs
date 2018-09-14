namespace kütüphane
{
    partial class ana_menu
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
            this.btn_sfr = new System.Windows.Forms.Button();
            this.btn_kullanici = new System.Windows.Forms.Button();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_yeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_sfr
            // 
            this.btn_sfr.Location = new System.Drawing.Point(156, 237);
            this.btn_sfr.Name = "btn_sfr";
            this.btn_sfr.Size = new System.Drawing.Size(99, 23);
            this.btn_sfr.TabIndex = 7;
            this.btn_sfr.Text = "Şifremi Unuttum";
            this.btn_sfr.UseVisualStyleBackColor = true;
            this.btn_sfr.Click += new System.EventHandler(this.btn_sfr_Click);
            // 
            // btn_kullanici
            // 
            this.btn_kullanici.Location = new System.Drawing.Point(156, 187);
            this.btn_kullanici.Name = "btn_kullanici";
            this.btn_kullanici.Size = new System.Drawing.Size(99, 23);
            this.btn_kullanici.TabIndex = 6;
            this.btn_kullanici.Text = "Kullanıcı Girişi";
            this.btn_kullanici.UseVisualStyleBackColor = true;
            this.btn_kullanici.Click += new System.EventHandler(this.btn_kullanici_Click);
            // 
            // btn_admin
            // 
            this.btn_admin.Location = new System.Drawing.Point(156, 139);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(99, 23);
            this.btn_admin.TabIndex = 5;
            this.btn_admin.Text = "Admin Girişi";
            this.btn_admin.UseVisualStyleBackColor = true;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            // 
            // btn_yeni
            // 
            this.btn_yeni.Location = new System.Drawing.Point(156, 90);
            this.btn_yeni.Name = "btn_yeni";
            this.btn_yeni.Size = new System.Drawing.Size(99, 23);
            this.btn_yeni.TabIndex = 4;
            this.btn_yeni.Text = "Yeni Kullanıcı";
            this.btn_yeni.UseVisualStyleBackColor = true;
            this.btn_yeni.Click += new System.EventHandler(this.btn_yeni_Click);
            // 
            // ana_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::kütüphane.Properties.Resources.kitap;
            this.ClientSize = new System.Drawing.Size(410, 350);
            this.Controls.Add(this.btn_sfr);
            this.Controls.Add(this.btn_kullanici);
            this.Controls.Add(this.btn_admin);
            this.Controls.Add(this.btn_yeni);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ana_menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Menü";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sfr;
        private System.Windows.Forms.Button btn_kullanici;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Button btn_yeni;
    }
}