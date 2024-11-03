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
    public partial class FilmDetaylarıGoruntule : Form
    {
        public FilmDetaylarıGoruntule()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; DataBase=filmkutuphanesiyonetimsistemi; user ID=postgres;password=1234");
        private void Btn_detayGor_Click(object sender, EventArgs e)
        {   //FİLMİN DETAYLARINI GORUNTULE
            string sorgu2 = "select f.filmid,f.filmadi,f.filmoyuncular,f.filmyonetmen,f.filmyayinyili,f.filmtur,AVG(fd.filmdegerlendirme) AS ortalama,fy.filmyorum from film f JOIN filmdegerelendirme fd ON f.filmadi=fd.filmadi JOIN filmyorum fy ON f.filmadi=fy.filmadi GROUP BY f.filmid,f.filmadi,f.filmoyuncular,f.filmyonetmen,f.filmyayinyili,f.filmtur ,fy.filmyorum; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView7.DataSource = ds.Tables[0];
        }
    }
}
