namespace NesneButunlemeProje
{
    partial class Filmistatistik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Filmistatistik));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_yuksekPuanlistele = new System.Windows.Forms.Button();
            this.Btn_encokDegerlendirilenler = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(328, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_yuksekPuanlistele
            // 
            this.Btn_yuksekPuanlistele.Location = new System.Drawing.Point(147, 391);
            this.Btn_yuksekPuanlistele.Name = "Btn_yuksekPuanlistele";
            this.Btn_yuksekPuanlistele.Size = new System.Drawing.Size(120, 23);
            this.Btn_yuksekPuanlistele.TabIndex = 1;
            this.Btn_yuksekPuanlistele.Text = "Yuksek Puan Listele";
            this.Btn_yuksekPuanlistele.UseVisualStyleBackColor = true;
            this.Btn_yuksekPuanlistele.Click += new System.EventHandler(this.Btn_yuksekPuanlistele_Click);
            // 
            // Btn_encokDegerlendirilenler
            // 
            this.Btn_encokDegerlendirilenler.Location = new System.Drawing.Point(558, 391);
            this.Btn_encokDegerlendirilenler.Name = "Btn_encokDegerlendirilenler";
            this.Btn_encokDegerlendirilenler.Size = new System.Drawing.Size(208, 23);
            this.Btn_encokDegerlendirilenler.TabIndex = 3;
            this.Btn_encokDegerlendirilenler.Text = "En Çok Değerlendirilenleri Listele";
            this.Btn_encokDegerlendirilenler.UseVisualStyleBackColor = true;
            this.Btn_encokDegerlendirilenler.Click += new System.EventHandler(this.Btn_encokDegerlendirilenler_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(418, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(377, 171);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(8, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "PUANI EN YÜKSEK FİLMLERİ LİSTELE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(414, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "EN ÇOK DEĞERLENDİRİLEN FİLMLERİN LİSTESİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(286, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "FİLM RAPORU EKRANI";
            // 
            // Filmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(888, 538);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_encokDegerlendirilenler);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.Btn_yuksekPuanlistele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Filmistatistik";
            this.Text = "Filmistatistik";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_yuksekPuanlistele;
        private System.Windows.Forms.Button Btn_encokDegerlendirilenler;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}