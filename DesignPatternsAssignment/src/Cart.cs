using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsAssignment.src
{
    public class Cart
    {
        public double IndirimHesapla(double toplamFiyat, string indirimTuru)
        {
            double indirimMiktari = 0;

            
            if (indirimTuru == "ogrenci")
            {
                indirimMiktari = toplamFiyat * 10 / 100;
            }

            
            else if (indirimTuru == "yilbasi")
            {
                indirimMiktari = toplamFiyat * 20 / 100;
            }

            
            else if (indirimTuru == "premium")
            {
                indirimMiktari = toplamFiyat * 15 / 100;
            }

            return toplamFiyat - indirimMiktari;
        }
    }
}