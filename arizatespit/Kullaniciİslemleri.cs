using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arizatespit
{
    public class Kullaniciİslemleri
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MDEUKG0;Initial Catalog=arizatakip;Integrated Security=True");
        SqlCommand ekle;  
        SqlDataReader oku; 
        Form2 frm = new Form2();

        public void KullaniciGirisi(TextBox kullaniciadi, TextBox sifre)
        {
            baglanti.Open();
            ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandText = "select *from kullanicibilgileri where KullaniciAdi = '" + kullaniciadi.Text + "'";
            oku = ekle.ExecuteReader();
            if (oku.Read() == true)
            {
                if (sifre.Text == oku["Sifre"].ToString())
                {
                    MessageBox.Show("Giriş Başarılı");
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Şifrenizi kontrol ediniz.", "Hata");
                }
            }
            else
            {
                MessageBox.Show("Bilgilerinizi kontrol ediniz.", "Hata");
            }
            baglanti.Close();
        }


        public void YeniKullanici(TextBox adsoyad, TextBox kullaniciadi, TextBox sifre, Label guvenlik, TextBox guvenlikkontrol)
        {

            baglanti.Open();
            ekle = new SqlCommand();
            ekle.Connection = baglanti;
            ekle.CommandText = "insert into kullanicibilgileri values ('" + adsoyad.Text + "','" + kullaniciadi.Text + "','" + sifre.Text + "')";
            ekle.ExecuteNonQuery();
            baglanti.Close();

        }
    }
}