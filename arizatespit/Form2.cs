using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static arizatespit.Form2;

namespace arizatespit
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        ArizaBilgisi arizabigisi = new ArizaBilgisi();
        private void ArizaBildir_button_Click(object sender, EventArgs e)
        {
            arizabigisi.AracBilgisiGirin(textBoxAdSoyad, textBoxTelNo, textBoxSehir, textBoxSeriNo, comboBoxMarkaSec, comboBoxTip, textBoxModel, textBoxRenk, comboBoxKasko, dateTimePicker1, comboBoxArizaSec, textBoxPlaka);
            MessageBox.Show("Kaydınız alınmıştır.", "Bilgi");


            string adsoyad = textBoxAdSoyad.Text;
            string telefon = textBoxTelNo.Text;
            string sehir = textBoxSehir.Text;
            string tarih = dateTimePicker1.Text;
            string serino = textBoxSeriNo.Text;
            string marka = comboBoxMarkaSec.Text;
            string tipi = comboBoxTip.Text;
            string modeli = textBoxModel.Text;
            string rengi = textBoxRenk.Text;
            string kasko = comboBoxKasko.Text;
            string ariza = comboBoxArizaSec.Text;
            string plaka = textBoxPlaka.Text;
        }

        Fiyatlandirma fiyatlandirma;

        private void buttonHesapla_Click(object sender, EventArgs e)
        {
            fiyatlandirma = new Fiyatlandirma();
            string marka = comboBoxMarkaSec.Text;
            string arizaTuru = comboBoxArizaSec.Text;
            string tipi = comboBoxTip.Text;
            string model = textBoxModel.Text;
            double toplamFiyat = fiyatlandirma.HesaplaFiyat(marka, arizaTuru, tipi, model);

            label21.Text = "1000 TL";

            if (comboBoxKasko.SelectedIndex == 0)
            {
                MessageBox.Show("Arızayı kasko karşılayacaktır. Sadece işçilik ücreti ödenecektir.", "İyi Günler");
                label15.Text = "1000 TL";
                label17.Text = "00 TL";
                label19.Text = "00 TL";
                label22.Text = "00 TL";
                label24.Text = "00 TL";

            }
            else
            {
                label19.Text = fiyatlandirma.ArizaTuruFarki.ToString() + " TL";
                label17.Text = fiyatlandirma.MarkaFarki.ToString() + " TL";
                label22.Text = fiyatlandirma.TipFarki.ToString() + " TL";
                label24.Text = fiyatlandirma.ModelFarki.ToString() + " TL";

                label15.Text = toplamFiyat.ToString() + " TL";
            }
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