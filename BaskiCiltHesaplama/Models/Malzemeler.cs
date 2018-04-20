using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaskiCiltHesaplama.Models
{
    public class Malzemeler
    {
        public double Uzunluk { get; set; }
        public double Genislik { get; set; }
        public double Hesap { get; set; }

        public enum MalzemeListesi
        {
            CiltBezi,
            Kagit,
            Klise,
            Kurdele,
            Mukavva,
            Ambalaj,
            BaskiBoya,
            Kalip,
            Seraze,
            Iplik,
            TelDikis
        }


        public double Hesapla()
        {
           
                Uzunluk += 2;
                Genislik += 2;
                Hesap = Uzunluk * Genislik;
                return Hesap;
            
        }
    }
}
