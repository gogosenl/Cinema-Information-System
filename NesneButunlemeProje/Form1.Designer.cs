namespace NesneButunlemeProje
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Btn_yoneticiGirisi = new System.Windows.Forms.Button();
            this.Btn_kullaniciGiriş = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_yoneticiGirisi
            // 
            this.Btn_yoneticiGirisi.Location = new System.Drawing.Point(289, 266);
            this.Btn_yoneticiGirisi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_yoneticiGirisi.Name = "Btn_yoneticiGirisi";
            this.Btn_yoneticiGirisi.Size = new System.Drawing.Size(137, 28);
            this.Btn_yoneticiGirisi.TabIndex = 0;
            this.Btn_yoneticiGirisi.Text = "Yönetici Girişi";
            this.Btn_yoneticiGirisi.UseVisualStyleBackColor = true;
            this.Btn_yoneticiGirisi.Click += new System.EventHandler(this.Btn_yoneticiGirisi_Click);
            // 
            // Btn_kullaniciGiriş
            // 
            this.Btn_kullaniciGiriş.Location = new System.Drawing.Point(717, 266);
            this.Btn_kullaniciGiriş.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_kullaniciGiriş.Name = "Btn_kullaniciGiriş";
            this.Btn_kullaniciGiriş.Size = new System.Drawing.Size(155, 28);
            this.Btn_kullaniciGiriş.TabIndex = 1;
            this.Btn_kullaniciGiriş.Text = "Kullanıcı Girişi";
            this.Btn_kullaniciGiriş.UseVisualStyleBackColor = true;
            this.Btn_kullaniciGiriş.Click += new System.EventHandler(this.Btn_kullaniciGiriş_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(338, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Film Kütüpanesi Yönetim Sisemine Hoşgeldiniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(432, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(363, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Yapmak İstediğiniz İşlemi Seçiniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1157, 576);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_kullaniciGiriş);
            this.Controls.Add(this.Btn_yoneticiGirisi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_yoneticiGirisi;
        private System.Windows.Forms.Button Btn_kullaniciGiriş;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

