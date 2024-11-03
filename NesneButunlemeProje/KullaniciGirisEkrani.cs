using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneButunlemeProje
{
    public partial class KullaniciGirisEkrani : Form
    {
        
        public KullaniciGirisEkrani()
        {
            InitializeComponent();
            
         

        }
        private void Btn_StandartKullanici_Click(object sender, EventArgs e)
        {
            StandartKullaniciKayitOL standartKullaniciKayitOL = new StandartKullaniciKayitOL();
            standartKullaniciKayitOL.Show();
        }

        private void Btn_PremiumKullanici_Click(object sender, EventArgs e)
        {
            PremiumKullaniciKayitOl premiumKullaniciKayitOl = new PremiumKullaniciKayitOl();
            premiumKullaniciKayitOl.Show();
        }

        private void Btn_GirisYap_Click(object sender, EventArgs e)
        {

            
            KullaniciEkrani kullaniciEkrani = new KullaniciEkrani();
            StandartKullaniciEkrani standartKullaniciEkrani = new StandartKullaniciEkrani();
            string girisYapanKullaniciAdi = textBox1.Text;
            string girisYapanSifre = textBox2.Text; 



            if (girisYapanKullaniciAdi == "gorkem" && girisYapanSifre == "gorkem")
            {
                MessageBox.Show("Giriş başarılı.");

                
                if (radiobtn_Standart.Checked)
                {
                    standartKullaniciEkrani.Show();
                }
                else
                {
                    kullaniciEkrani.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }


            
            

           
        }

        private void Btn_kayitekrani_Click(object sender, EventArgs e)
        {
            tabPage2.Show();
            
        }

        private void KullaniciGirisEkrani_Load(object sender, EventArgs e)
        {
            if (radioButtonsifre.Checked) 
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                radioButtonsifre.Checked = false;
            }
        }
    } 
}
