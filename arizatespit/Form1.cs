using System;
using System.Data.SqlClient;

namespace arizatespit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        KullaniciÝslemleri kullnci = new KullaniciÝslemleri();


        private void buttonGirisYap_Click_1(object sender, EventArgs e)
        {
            if (Guvenliklabel.Text == GuvenliktextBox.Text)
            {
                kullnci.KullaniciGirisi(textBoxKullaniciAdi, textBoxSifre);
            }
            else
            {
                MessageBox.Show("Güvenlik kodunu yanlýþ girdiniz.", "Hata");
            }
        }

        private void buttonKayitOl_Click(object sender, EventArgs e)
        {
            kullnci.YeniKullanici(AdSoyadtextBox, KullaniciAditextBox, SifretextBox, Guvenliklabel, GuvenliktextBox);
            MessageBox.Show("Üye baþarýyla eklendi.", "Bilgi");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBoxYonetKullanici.Text;
            string sifre = textBoxYonetSifre.Text;
            if (kullaniciadi == "admin")
            {
                if (sifre == "123")
                {
                    if (labelGuvenlik.Text == textBoxGuvenlik.Text)
                    {
                        Form3 frm3 = new Form3();
                        frm3.Show();
                    }
                    else
                    {
                        MessageBox.Show("Güvenlik kodunu yanlýþ girdiniz.", "Hata");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int kod, kod2;
            Random random = new Random();
            kod = random.Next(1000, 9999);
            kod2 = random.Next(1000, 9999);
            Guvenliklabel.Text = kod.ToString();
            labelGuvenlik.Text = kod2.ToString();
        }

        private void label26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuvenliktextBox_TextChanged(object sender, EventArgs e)
        {
            if (Guvenliklabel.Text == GuvenliktextBox.Text)
            {
                buttonGirisYap.Enabled = true;
            }
            else
            {
                buttonGirisYap.Enabled = false;
            }
        }

        private void textBoxGuvenlik_TextChanged(object sender, EventArgs e)
        {
            if(labelGuvenlik.Text == textBoxGuvenlik.Text)
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }
    }
}