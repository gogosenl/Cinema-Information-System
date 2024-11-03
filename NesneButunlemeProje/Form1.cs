using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneButunlemeProje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_yoneticiGirisi_Click(object sender, EventArgs e)
        {
            YoneticiGirisEkrani yoneticiGirisEkrani = new YoneticiGirisEkrani();
            yoneticiGirisEkrani.Show();
        }

        private void Btn_kullaniciGiriş_Click(object sender, EventArgs e)
        {
            KullaniciGirisEkrani kullaniciGirisEkrani = new KullaniciGirisEkrani();  
            kullaniciGirisEkrani.Show();
        }
    }
}
