using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arizatespit
{
    public class Fiyatlandirma
    {
        public double ArizaTuruFarki { get; set; }
        public double MarkaFarki { get; set; }
        public double TipFarki { get; set; }
        public double ModelFarki { get; set; }


        public double HesaplaFiyat(string marka, string arizaTuru,string tipi,string model)
        {
            double temelFiyat = 1000; 
            double markaFarki = 0;
            double arizaTuruFarki = 0;
            double tipFarki = 0;
            double modelFarki = 0;

            if (marka.ToLower() == "audi")
                markaFarki = 10000;
            else if (marka.ToLower() == "bmw")
                markaFarki = 11000;
            else if(marka.ToLower() == "chevrolet")
                markaFarki = 3000;
            else if(marka.ToLower() == "citroen")
                markaFarki = 3500;
            else if (marka.ToLower() == "dacia")
                markaFarki = 3000;
            else if (marka.ToLower() == "ferrari")
                markaFarki = 22000;
            else if (marka.ToLower() == "fiat")
                markaFarki = 3500;
            else if (marka.ToLower() == "ford")
                markaFarki = 6500;
            else if (marka.ToLower() == "honda")
                markaFarki = 5000;
            else if (marka.ToLower() == "hyundai")
                markaFarki = 5000;
            else if (marka.ToLower() == "lamborghini")
                markaFarki = 35000;
            else if (marka.ToLower() == "maserati")
                markaFarki = 33000;
            else if (marka.ToLower() == "mercedes")
                markaFarki = 10500;
            else if (marka.ToLower() == "mini")
                markaFarki = 8000;
            else if(marka.ToLower() == "mitsubishi")
                markaFarki = 4000;
            else if (marka.ToLower() == "nissan")
                markaFarki = 7500;
            else if (marka.ToLower() == "opel")
                markaFarki = 7500;
            else if (marka.ToLower() == "peugeot")
                markaFarki = 6500;
            else if (marka.ToLower() == "porcshe")
                markaFarki = 28000;
            else if (marka.ToLower() == "renault")
                markaFarki = 7000;
            else if (marka.ToLower() == "seat")
                markaFarki = 6000;
            else if (marka.ToLower() == "skoda")
                markaFarki = 7000;
            else if (marka.ToLower() == "toyota")
                markaFarki = 8000;
            else if (marka.ToLower() == "togg")
                markaFarki = 3000;
            else if (marka.ToLower() == "volkswagen")
                markaFarki = 10000;
            else if (marka.ToLower() == "volvo")
                markaFarki = 15000;
            


            if (arizaTuru.ToLower() == "motor arızası")
                arizaTuruFarki = 10000;
            else if (arizaTuru.ToLower() == "elektrik arızası")
                arizaTuruFarki = 400;
            else if (arizaTuru.ToLower() == "akü bitmesi")
                arizaTuruFarki = 1000;
            else if (arizaTuru.ToLower() == "lastik patlaması")
                arizaTuruFarki = 250;
            else if (arizaTuru.ToLower() == "fren arızası")
                arizaTuruFarki = 500;
            else if (arizaTuru.ToLower() == "yağ azalması")
                arizaTuruFarki = 200;
            else if (arizaTuru.ToLower() == "marş arızası")
                arizaTuruFarki = 750;
            else if (arizaTuru.ToLower() == "yakıt pompası arızası")
                arizaTuruFarki = 800;
            else if (arizaTuru.ToLower() == "şanzıman arızası")
                arizaTuruFarki = 3000;
            else if (arizaTuru.ToLower() == "boyama işlemi")
                arizaTuruFarki = 500;
            else if (arizaTuru.ToLower() == "aks sorunu")
                arizaTuruFarki = 4000;
            else if (arizaTuru.ToLower() == "amortisör sorunu")
                arizaTuruFarki = 700;
            else if (arizaTuru.ToLower() == "vites dişli bozulması")
                arizaTuruFarki = 1000;
            else if (arizaTuru.ToLower() == "radyatör arızası")
                arizaTuruFarki = 900;
            else if (arizaTuru.ToLower() == "hararet yapması")
                arizaTuruFarki = 400;
            else if (arizaTuru.ToLower() == "direksiyon sertleşmesi")
                arizaTuruFarki = 500;
            else if (arizaTuru.ToLower() == "yakıt deposu arızası")
                arizaTuruFarki = 500;



            if (tipi.ToLower() == "otomobil")
                tipFarki = 2000;
            else if(tipi.ToLower() == "suv")
                tipFarki = 3000;
            else if (tipi.ToLower() == "kamyon")
                tipFarki = 8000;
            else if (tipi.ToLower() == "minivan")
                tipFarki = 1000;
            else if (tipi.ToLower() == "panelvan")
                tipFarki = 3500;
            else if (tipi.ToLower() == "pickup")
                tipFarki = 4000;
            else if (tipi.ToLower() == "tır")
                tipFarki = 15000;
            else if (tipi.ToLower() == "arazi")
                tipFarki = 3000;


            
            if (model.Length == 4 && int.TryParse(model, out int modeli)) 
            {
                if (modeli <= 2023 && modeli >= 2020)
                    modelFarki = 10000;
                else if (modeli < 2020 && modeli >= 2015)
                    modelFarki = 7000;
                else if (modeli < 2015 && modeli >= 2010)
                    modelFarki = 6000;
                else if (modeli < 2010 && modeli >= 2005)
                    modelFarki = 5000;
                else if (modeli < 2005 && modeli >= 2000)
                    modelFarki = 2000;
                else if (modeli < 2000 && modeli >= 1995)
                    modelFarki = 1000;
                else if (modeli < 1995 && modeli >= 1990)
                    modelFarki = 900;
                else if (modeli < 1990 && modeli >= 1985)
                    modelFarki = 1000;
                else if (modeli < 1985 && modeli >= 1980)
                    modelFarki = 2000;
                else if (modeli < 1980 && modeli >= 1975)
                    modelFarki = 6000;
                else if (modeli < 1975 && modeli >= 1970)
                    modelFarki = 6000;
                else if (modeli < 1970 && modeli >= 1965)
                    modelFarki = 6500;
                else if (modeli < 1965 && modeli >= 1960)
                    modelFarki = 7000;
                else
                {
                    MessageBox.Show("Çok eski bir model girdiğiniz için parça bulunmamaktadır.", "Bilgi");
                }
            }


            double toplamFiyat = temelFiyat + markaFarki + arizaTuruFarki + tipFarki + modelFarki;

            ArizaTuruFarki = arizaTuruFarki;
            MarkaFarki = markaFarki;
            TipFarki = tipFarki;
            ModelFarki = modelFarki;

            return toplamFiyat;
        }
    }
}
