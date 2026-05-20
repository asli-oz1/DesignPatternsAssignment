using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatternsAssignment.src.Yapisal;

namespace DesignPatternsAssignment.src
{
    public class AlisverisFacade
    {
        public void SiparisiTamamla(Cart sepet)
        {
            double toplam =
                sepet.IndirimHesapla("ogrenci");

            KuponDecorator kupon =
                new KuponDecorator();

            toplam =
                kupon.KuponUygula(toplam);

            Console.WriteLine(
            "Son fiyat: " + toplam);
        }
    }
}