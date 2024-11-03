using Npgsql;
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
    public partial class StandartKullaniciEkrani : Form
    {
        public StandartKullaniciEkrani()
        {
            InitializeComponent();
        }

        private void StandartKullaniciEkrani_Load(object sender, EventArgs e)
        {

        }
        public NpgsqlConnection baglanti= new NpgsqlConnection("server=localhost; port=5432; DataBase=filmkutuphanesiyonetimsistemi; user ID=postgres;password=1234");
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_ara_Click(object sender, EventArgs e)
        {
            
        }

        

        private void Btn_yorumgoster_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Degerlendir_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut1 = new NpgsqlCommand("insert into filmdegerelendirme (filmadi,filmdegerlendirme) values(@p1,@p2)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Txt_degerlendirilenfilmadi.Text);
            komut1.Parameters.AddWithValue("@p2", Convert.ToDouble(Txt_filmDegerelendirmesi.Text));



            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yorumlama Başarılı");

            baglanti.Close();
        }

        private void Btn_degerlendirilenleriGoster_Click(object sender, EventArgs e)
        {
            string sorgu3 = "select * from filmdegerelendirme";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu3, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }


        DataTable tablo3 = new DataTable();
        private void Btn_Ekle_Click_1(object sender, EventArgs e)
        {

           
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
        }

        private void Btn_izledim_Click(object sender, EventArgs e)
        {
            
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

                MessageBox.Show("Seçili satır aktarıldı.");
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
                // Sütunları tanımla (dataGridView2'de daha önceden sütun tanımlanmamışsa)


                // Seçili satırın indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırın verilerini al
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'ye seçili satırın bilgilerini ekle
                dataGridView6.Rows.Add(values);

                MessageBox.Show("Seçili satır aktarıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void KullaniciEkrani_Load(object sender, EventArgs e)
        {

        }

       

        private void Btn_yorumgoster_Click_1(object sender, EventArgs e)
        {
            string sorgu2 = "select * from filmyorum";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }

        private void Btn_Listele_Click_1(object sender, EventArgs e)
        {
            string sorgu = "select * from film";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btn_ara_Click_1(object sender, EventArgs e)
        {
            NpgsqlCommand komut1 = new NpgsqlCommand("SELECT * FROM  film WHERE film.filmadi=@p1", baglanti);

            using (NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut1))
            {
                // Parametre ekleme
                da.SelectCommand.Parameters.AddWithValue("@p1", Txt_filmadi.Text);

                // DataSet oluştur
                DataSet ds = new DataSet();

                // Verileri çekmek ve DataSet'e atamak
                da.Fill(ds);

                // DataSet'i DataGridView'e atamak
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void Btn_izledim_Click_1(object sender, EventArgs e)
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

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Sütunları tanımla (dataGridView2'de daha önceden sütun tanımlanmamışsa)


                // Seçili satırın indeksini al
                int seciliIndex = dataGridView1.SelectedRows[0].Index;

                // Seçili satırın verilerini al
                object[] values = new object[dataGridView1.Columns.Count];
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    values[i] = dataGridView1.Rows[seciliIndex].Cells[i].Value;
                }

                // DataGridView2'ye seçili satırın bilgilerini ekle
                dataGridView5.Rows.Add(values);

                MessageBox.Show("Seçili satır aktarıldı.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void Btn_Sil_Click_1(object sender, EventArgs e)
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
                        MessageBox.Show("DataGridView5 sütun sayısı, DataGridView1 sütun sayısıyla eşleşmiyor.");
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

                MessageBox.Show("Seçili satır silindi.");
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.");
            }
        }

        private void Btn_Güncelle_Click_1(object sender, EventArgs e)
        {

        }
    }
}

    

