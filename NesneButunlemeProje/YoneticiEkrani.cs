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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesneButunlemeProje
{
    public partial class YoneticiEkrani : Form
    {
        public YoneticiEkrani()
        {
            InitializeComponent();
        }

       

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; DataBase=filmkutuphanesiyonetimsistemi; user ID=postgres;password=1234");


        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut1 = new NpgsqlCommand("insert into film (filmid,filmyonetmen,filmoyuncular,filmtur,filmyayinyili,filmadi) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(Txt_filmid.Text));
            komut1.Parameters.AddWithValue("@p2", Txt_filmyonetmen.Text);
            komut1.Parameters.AddWithValue("@p3", Txt_filmoyuncular.Text);
            komut1.Parameters.AddWithValue("@p4", Txt_filmtur.Text);
            komut1.Parameters.AddWithValue("@p5", Convert.ToDouble(Txt_filmyapimyili.Text));
            komut1.Parameters.AddWithValue("@p6", Txt_filmadi.Text);


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklemi İşlemi Başarılı");

            baglanti.Close();
        }

        private void btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();



            NpgsqlCommand komut1 = new NpgsqlCommand("update film set filmadi=@p6,filmyonetmen = @p2, filmoyuncu = @p3, filmtur = @p4, filmyayinyili = @p5,where filmid=@p1", baglanti);
            komut1.Parameters.AddWithValue("@p1", Convert.ToInt32(Txt_filmid.Text));
            komut1.Parameters.AddWithValue("@p6", Txt_filmyonetmen.Text);
            komut1.Parameters.AddWithValue("@p2", Txt_filmyonetmen.Text);
            komut1.Parameters.AddWithValue("@p3", Txt_filmoyuncular.Text);
            komut1.Parameters.AddWithValue("@p4", Txt_filmtur.Text);
            komut1.Parameters.AddWithValue("@p5", Convert.ToDouble(Txt_filmyapimyili.Text));


            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Eklemi İşlemi Başarılı");

            baglanti.Close();
        }
    }
}
