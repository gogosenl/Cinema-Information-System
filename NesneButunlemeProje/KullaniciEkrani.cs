using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneButunlemeProje
{
    public partial class KullaniciEkrani : Form
    {

     

        public KullaniciEkrani()
        {
            InitializeComponent();
            
        }
        
        


        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; DataBase=filmkutuphanesiyonetimsistemi; user ID=postgres;password=1234");
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from film";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btn_ara_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT * FROM  film WHERE film.filmadi=@p1", baglanti);

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1))
            {
                da.SelectCommand.Parameters.AddWithValue("@p1", Txt_filmadi.Text);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Btn_yorumla_Click(object sender, EventArgs e)
        {

            baglanti.Open();



            NpgsqlCommand komut1 = new NpgsqlCommand("insert into filmyorum (filmadi,filmyorum) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Txt_yorumlanacakfilmadi.Text);
            komut1.Parameters.AddWithValue("@p2", richTxt_filmyorumu.Text);
     


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yorumlama Başarılı");

            baglanti.Close();
        }

        private void Btn_yorumgoster_Click(object sender, EventArgs e)
        {
            string sorgu2 = "select * from filmyorum";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
        public static List<Kullanici> KullaniciListesi { get; set; } = new List<Kullanici>();

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txt_kullaniciadi.Text;
            Kullanici kullanici = KullaniciListesi.FirstOrDefault(k => k.KullaniciAdi == kullaniciAdi);

            if (kullanici != null)
            {
                kullanici.Sifre = txt_sifre.Text;
                kullanici.AdSoyad = txt_AdSoyad.Text;
                kullanici.Tc = Convert.ToInt32(txt_TCno.Text);
                kullanici.DogumTarihi = Convert.ToDateTime(txt_dogumtarihi.Text);
                kullanici.Cinsiyet = comboBoxcinsiyet.Text;

                MessageBox.Show("Bilgileriniz Güncellendi");
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void Btn_Degerlendir_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut1 = new NpgsqlCommand("insert into filmdegerelendirme (filmadi,filmdegerlendirme) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Txt_degerlendirilenfilmadi.Text);
            komut1.Parameters.AddWithValue("@p2", Convert.ToDouble(Txt_filmDegerelendirmesi.Text));



            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Değerlendirme Başarılı");

            baglanti.Close();
        }

        private void Btn_degerlendirilenleriGoster_Click(object sender, EventArgs e)
        {
            string sorgu3 = "select filmadi,AVG(filmdegerlendirme) AS ortalama_puan from filmdegerelendirme GROUP BY filmadi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu3, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }
       
        
        DataTable tablo3 = new DataTable();
        private void Btn_Ekle_Click_1(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
  
                // indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // verilerini al
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'ye seçili satırın bilgilerini ekle
                dataGridView5.Rows.Add(values);

                MessageBox.Show("Film izleme listenize eklendi.");
            }
            else
            {
                MessageBox.Show("Lütfen Film seçin.");
            }
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Seçili satırın indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırın verilerini al
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'den seçili satırın bilgilerini sil
                foreach (DataGridViewRow row in dataGridView5.Rows)
                {
                    // DataGridView5'teki sütun sayısını kontrol et
                    if (row.Cells.Count != dataGridView1.Columns.Count)
                    {
                        MessageBox.Show("Film izleme listenizde yok.");
                        return;
                    }

                    bool satirEsit = true;
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (!values[i].Equals(row.Cells[i].Value))
                        {
                            satirEsit = false;
                            break;
                        }
                    }

                    if (satirEsit)
                    {
                        dataGridView5.Rows.Remove(row);
                        break;
                    }
                }

                MessageBox.Show("Seçili film izleme listenizden silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir film seçin.");
            }
        }

        private void Btn_izledim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

               
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

               
                foreach (DataGridViewRow row in dataGridView5.Rows)
                {
                    bool satirEsit = true;
                    for (int i = 0; i < dataGridView5.Columns.Count; i++)
                    {
                        if (!values[i].Equals(row.Cells[i].Value))
                        {
                            satirEsit = false;
                            break;
                        }
                    }

                    if (satirEsit)
                    {
                        dataGridView5.Rows.Remove(row);
                        break;
                    }
                }

                MessageBox.Show("İzlenilen Film İşaretlendi.İzleme listende ise silinecektir!!!");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void Btn_begendim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'ye seçili satırın bilgilerini ekle
                dataGridView4.Rows.Add(values);

                MessageBox.Show("Film beğenilen listenize eklendi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void Btn_begenmedim_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
   
                
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırın verilerini al
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'ye seçili satırın bilgilerini ekle
                dataGridView6.Rows.Add(values);

                MessageBox.Show("Film beğenmediklerim listenize eklendi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {
           
        }

        

        private void Btn_detayGor_Click_1(object sender, EventArgs e)
        {
            FilmDetaylarıGoruntule filmDetaylarıGoruntule=new FilmDetaylarıGoruntule();
            filmDetaylarıGoruntule.Show();
        }

        private void Btn_filmistatistik_Click(object sender, EventArgs e)
        {
            Filmistatistik filmistatistik = new Filmistatistik();   
            filmistatistik.Show();
        }

        private void Btn_araTur_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("SELECT * FROM  film WHERE film.filmtur=@p1", baglanti);

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut2))
            {
                da.SelectCommand.Parameters.AddWithValue("@p1", Txt_filmTuru.Text);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Btn_araYonetmen_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut3 = new NpgsqlCommand("SELECT * FROM  film WHERE film.filmyonetmen=@p1", baglanti);

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut3))
            {
                da.SelectCommand.Parameters.AddWithValue("@p1", Txt_yonetmenAdi.Text);

                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Btn_hesabiKapat_Click(object sender, EventArgs e)
        {
            DialogResult onay = MessageBox.Show("Hesabı Kapatmak İstediğinize Emin Misiniz?", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (onay == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                
                MessageBox.Show("İşlem iptal edildi.");
            }
        }
    }
}
