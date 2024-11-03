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
    public partial class Filmistatistik : Form
    {
        public Filmistatistik()
        {
            InitializeComponent();
        }
        public NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost; port=5432; DataBase=filmkutuphanesiyonetimsistemi; user ID=postgres;password=1234");
        private void Btn_yuksekPuanlistele_Click(object sender, EventArgs e)
        {//EN YUKSEK PUANLI FİLMLERİ LİSTELE
            string sorgu1 = "select filmadi,AVG(filmdegerlendirme) AS ortalama from filmdegerelendirme GROUP BY filmadi ORDER BY ortalama DESC; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu1, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btn_encokDegerlendirilenler_Click(object sender, EventArgs e)
        {//EN ÇOK DEĞERLENDİRİLEN FİLMLERİ LİSTELE
            string sorgu2 = "select f.filmadi, COUNT(fd.filmdegerlendirme) AS degerlendirmesayisi from film f JOIN filmdegerelendirme fd ON f.filmadi=fd.filmadi GROUP BY f.filmadi ORDER BY degerlendirmesayisi DESC ; ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu2, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
        }
    }
}
