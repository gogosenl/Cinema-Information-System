using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesneButunlemeProje
{
    public partial class YoneticiGirisEkrani : Form
    {
        public YoneticiGirisEkrani()
        {
            InitializeComponent();
        }

        private void Btn_GirisYap_Click(object sender, EventArgs e)
        {
            string girisYapanKullaniciAdi = Txt_kullaniciadi.Text;
            string girisYapanSifre = Txt_sifre.Text;
            YoneticiEkrani yoneticiEkrani = new YoneticiEkrani();


            if (girisYapanKullaniciAdi == "yoneticigorkem" && girisYapanSifre == "yoneticigorkem")
            {
                MessageBox.Show("Giriş başarılı.");
                yoneticiEkrani.Show();


            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }

             
           
        }

        private void YoneticiGirisEkrani_Load(object sender, EventArgs e)
        {
            if (radioButtonsifre.Checked)
            {
                Txt_sifre.UseSystemPasswordChar = true;
            }
            else
            {
                radioButtonsifre.Checked = false;
            }
        }
    }
}
