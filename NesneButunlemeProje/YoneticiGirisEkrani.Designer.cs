namespace NesneButunlemeProje
{
    partial class YoneticiGirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiGirisEkrani));
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Btn_GirisYap = new System.Windows.Forms.Button();
            this.Txt_sifre = new System.Windows.Forms.TextBox();
            this.Txt_kullaniciadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonsifre = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(185, 178);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(31, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Şifre:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(162, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "Kullanici Adi:";
            // 
            // Btn_GirisYap
            // 
            this.Btn_GirisYap.Location = new System.Drawing.Point(303, 273);
            this.Btn_GirisYap.Name = "Btn_GirisYap";
            this.Btn_GirisYap.Size = new System.Drawing.Size(75, 23);
            this.Btn_GirisYap.TabIndex = 9;
            this.Btn_GirisYap.Text = "Giris Yap";
            this.Btn_GirisYap.UseVisualStyleBackColor = true;
            this.Btn_GirisYap.Click += new System.EventHandler(this.Btn_GirisYap_Click);
            // 
            // Txt_sifre
            // 
            this.Txt_sifre.Location = new System.Drawing.Point(278, 171);
            this.Txt_sifre.Name = "Txt_sifre";
            this.Txt_sifre.Size = new System.Drawing.Size(100, 20);
            this.Txt_sifre.TabIndex = 8;
            this.Txt_sifre.UseSystemPasswordChar = true;
            // 
            // Txt_kullaniciadi
            // 
            this.Txt_kullaniciadi.Location = new System.Drawing.Point(278, 112);
            this.Txt_kullaniciadi.Name = "Txt_kullaniciadi";
            this.Txt_kullaniciadi.Size = new System.Drawing.Size(100, 20);
            this.Txt_kullaniciadi.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(215, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "YONETICI GİRİŞ EKRANINA HOŞGELDİNİZ";
            // 
            // radioButtonsifre
            // 
            this.radioButtonsifre.AutoSize = true;
            this.radioButtonsifre.Location = new System.Drawing.Point(777, 439);
            this.radioButtonsifre.Name = "radioButtonsifre";
            this.radioButtonsifre.Size = new System.Drawing.Size(28, 17);
            this.radioButtonsifre.TabIndex = 15;
            this.radioButtonsifre.TabStop = true;
            this.radioButtonsifre.Text = " ";
            this.radioButtonsifre.UseVisualStyleBackColor = true;
            this.radioButtonsifre.Visible = false;
            // 
            // YoneticiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonsifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Btn_GirisYap);
            this.Controls.Add(this.Txt_sifre);
            this.Controls.Add(this.Txt_kullaniciadi);
            this.Name = "YoneticiGirisEkrani";
            this.Text = "YoneticiGirisEkrani";
            this.Load += new System.EventHandler(this.YoneticiGirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button Btn_GirisYap;
        private System.Windows.Forms.TextBox Txt_sifre;
        private System.Windows.Forms.TextBox Txt_kullaniciadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonsifre;
    }
}