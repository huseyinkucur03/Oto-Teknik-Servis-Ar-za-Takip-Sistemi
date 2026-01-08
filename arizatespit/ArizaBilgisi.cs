using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arizatespit
{
    public class ArizaBilgisi
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-MDEUKG0;Initial Catalog=arizatakip;Integrated Security=True");
        SqlCommand ekle;  

        public void AracBilgisiGirin(TextBox adsoyad, TextBox telno, TextBox sehir, TextBox serino, ComboBox marka, ComboBox tip, TextBox model, TextBox renk, ComboBox kasko, DateTimePicker tarih, ComboBox ariza,TextBox plaka)
        {
            baglanti.Open();
            ekle = new SqlCommand();
            ekle.Connection = baglanti;


            ekle.CommandText = "INSERT INTO arizabilgi VALUES (@adsoyad, @telno, @sehir, @serino, @marka, @tip, @model, @renk, @kasko, @tarih,@ariza,@plaka)";

            ekle.Parameters.AddWithValue("@adsoyad", adsoyad.Text);
            ekle.Parameters.AddWithValue("@telno", telno.Text);
            ekle.Parameters.AddWithValue("@sehir", sehir.Text);
            ekle.Parameters.AddWithValue("@serino", serino.Text);
            ekle.Parameters.AddWithValue("@marka", marka.Text);
            ekle.Parameters.AddWithValue("@tip", tip.Text);
            ekle.Parameters.AddWithValue("@model", model.Text);
            ekle.Parameters.AddWithValue("@renk", renk.Text);
            ekle.Parameters.AddWithValue("@kasko", kasko.Text);
            ekle.Parameters.AddWithValue("@tarih", tarih.Value);
            ekle.Parameters.AddWithValue("@ariza", ariza.Text);
            ekle.Parameters.AddWithValue("@plaka", plaka.Text);
            ekle.ExecuteNonQuery();

            baglanti.Close();
        }
    }
}