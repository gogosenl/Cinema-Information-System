using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneButunlemeProje
{
    
        public abstract class Kullanici
        {
            public string KullaniciAdi { get; set; }
            public string Sifre { get; set; }
            public string AdSoyad { get; set; }
            public int Tc { get; set; }
            public DateTime DogumTarihi { get; set; }
            public string Cinsiyet { get; set; }
            public string UyelikTuru { get; set; }
            public bool Aktif { get; set; } = true;
            public abstract double UcretHesapla();
        }

        public class StandartKullanici : Kullanici
        {
            public bool IzlemeIzni { get; set; } = true;

            public StandartKullanici(string kullaniciAdi,string sifre,string adSoyad, int tc, DateTime dogumTarihi, string cinsiyet)
            {
                KullaniciAdi = kullaniciAdi;
                Sifre = sifre;
                AdSoyad = adSoyad;
                Tc = tc;
                DogumTarihi = dogumTarihi;
                Cinsiyet = cinsiyet;
                UyelikTuru = "Standart";
            }
            public override double UcretHesapla()
            {
                return 100;
            }

        }
        public class PremiumKullanici : Kullanici
        {
            public bool IzlemeIzni { get; set; } = true;

            public PremiumKullanici(string kullaniciAdi, string sifre,string adSoyad, int tc, DateTime dogumTarihi, string cinsiyet)
            {
                KullaniciAdi = kullaniciAdi;
                Sifre = sifre;
                AdSoyad = adSoyad;
                Tc = tc;
                DogumTarihi = dogumTarihi;
                Cinsiyet = cinsiyet;
                UyelikTuru = "Premium";
            }

            public override double UcretHesapla()
            {
            // Standart ücret üzerine %25 artış
            return 100 * 1.25;
            }
        }
    }

