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

namespace arizatespit
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MDEUKG0;Initial Catalog=arizatakip;Integrated Security=True");

        public void KayitGetir()
        {
            baglanti.Open();
            string getir = "select * from arizabilgi";

            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            ad.Fill(tablo);
            dataGridView1.DataSource = tablo;

            baglanti.Close();
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string getir = "select *from arizabilgi";

            SqlCommand komut = new SqlCommand(getir, baglanti);
            SqlDataAdapter ad = new SqlDataAdapter(komut);

            DataTable tablo = new DataTable();
            ad.Fill(tablo); 
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        private void buttonArama_Click(object sender, EventArgs e)
        {
            ListBoxSonuclariniTemizle();

            string textBoxValue = textBoxArama.Text.Trim().ToLower(); 
            if (string.IsNullOrEmpty(textBoxValue))  
            {
                KayitGetir();
            }
            if (radioButtonAdSoyad.Checked)
            {
                string kayit = "select *from arizabilgi where lower([Adı Soyadı])=@adsoyad";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@adsoyad", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitSayisi = tablo.Rows.Count; 
                listBoxSonuclar.Items.Add($"Adı Soyadı: {textBoxArama.Text}, Kayıt Sayısı: {kayitSayisi}");
            }
            else if (radioButtonSeriNo.Checked)
            {
                string kayit = "select *from arizabilgi where lower([Seri No])=@serino";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@serino", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitsayisi = tablo.Rows.Count;
                listBoxSonuclar.Items.Add($"Seri No: {textBoxArama.Text}, Kayıt Sayısı: {kayitsayisi}");
            }
            else if (radioButtonTip.Checked)
            {
                string kayit = "select *from arizabilgi where lower(Tipi)=@tip";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@tip", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitSayisi = tablo.Rows.Count;
                listBoxSonuclar.Items.Add($"Tip: {textBoxArama.Text}, Kayıt Sayısı: {kayitSayisi}");
            }
            else if (radioButtonSehir.Checked)
            {
                string kayit = "select *from arizabilgi where lower(Şehir)=@sehir";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@sehir", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitSayisi = tablo.Rows.Count;
                listBoxSonuclar.Items.Add($"Şehir: {textBoxArama.Text}, Kayıt Sayısı: {kayitSayisi}");
            }
            else if (radioButtonModel.Checked)
            {
                string kayit = "select *from arizabilgi where lower(Model)=@model";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@model", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitSayisi = tablo.Rows.Count;
                listBoxSonuclar.Items.Add($"Model: {textBoxArama.Text}, Kayıt Sayısı: {kayitSayisi}");
            }
            else if (radioButtonMarka.Checked)
            {
                string kayit = "select *from arizabilgi where lower(Marka)=@marka";
                SqlCommand komut = new SqlCommand(kayit, baglanti);

                komut.Parameters.AddWithValue("@marka", textBoxArama.Text);
                SqlDataAdapter da = new SqlDataAdapter(komut);

                DataTable tablo = new DataTable();
                da.Fill(tablo);
                dataGridView1.DataSource = tablo;
                baglanti.Close();

                int kayitSayisi = tablo.Rows.Count;
                listBoxSonuclar.Items.Add($"Marka: {textBoxArama.Text}, Kayıt Sayısı: {kayitSayisi}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void ListBoxSonuclariniTemizle()
        {
            listBoxSonuclar.Items.Clear(); 
        }

        private void label26_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Programdan çıkmak istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cikis == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            DialogResult GiriseDon = new DialogResult();
            GiriseDon = MessageBox.Show("Giriş ekranına dönmek istediğinize emin misiniz?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (GiriseDon == DialogResult.Yes)
            {
                frm.Show();
                this.Hide();
            }
        }
    }
}