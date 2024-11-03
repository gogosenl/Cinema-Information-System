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
    public partial class PremiumKullaniciKayitOl : Form
    {

        public static List<Kullanici> kullaniciListesi { get; set; } = new List<Kullanici>();
        public PremiumKullaniciKayitOl()
        {
            InitializeComponent();
        }

        private void Btn_Kayitol_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciadi.Text;
            string sifre = txt_sifre.Text;
            string adSoyad= txt_AdSoyad.Text;
            int tc = Convert.ToInt32(txt_TCno.Text);
            DateTime dogumTarihi = Convert.ToDateTime(txt_dogumtarihi.Text);
            string cinsiyet = combobox_Cinsiyet.Text;
            string uyelikTuru = "Premium";

            Kullanici kullanici;

            kullanici = new PremiumKullanici(kullaniciAdi,sifre,adSoyad, tc, dogumTarihi, cinsiyet);
            kullanici.KullaniciAdi = kullaniciAdi;
            kullanici.Sifre = sifre;
            kullaniciListesi.Add(kullanici);



            MessageBox.Show("Kayıt Olma Başarılı Ödenecek Tutar 125TL.Lütfen Giriş Yapınız");
            this.Hide();
        }
    }
}
