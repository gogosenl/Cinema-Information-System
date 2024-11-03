namespace NesneButunlemeProje
{
    partial class FilmDetaylarıGoruntule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmDetaylarıGoruntule));
            this.Btn_detayGor = new System.Windows.Forms.Button();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_detayGor
            // 
            this.Btn_detayGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_detayGor.Location = new System.Drawing.Point(657, 166);
            this.Btn_detayGor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Btn_detayGor.Name = "Btn_detayGor";
            this.Btn_detayGor.Size = new System.Drawing.Size(97, 28);
            this.Btn_detayGor.TabIndex = 3;
            this.Btn_detayGor.Text = "DetayGor";
            this.Btn_detayGor.UseVisualStyleBackColor = true;
            this.Btn_detayGor.Click += new System.EventHandler(this.Btn_detayGor_Click);
            // 
            // dataGridView7
            // 
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView7.Location = new System.Drawing.Point(28, 204);
            this.dataGridView7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.Size = new System.Drawing.Size(716, 183);
            this.dataGridView7.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "FİLM DETAYLARI GÖRÜNTÜLEME EKRANI";
            // 
            // FilmDetaylarıGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(913, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_detayGor);
            this.Controls.Add(this.dataGridView7);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FilmDetaylarıGoruntule";
            this.Text = "FilmDetaylarıGoruntule";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_detayGor;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Label label1;
    }
}