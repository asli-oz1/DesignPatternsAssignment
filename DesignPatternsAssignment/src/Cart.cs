
using DesignPatternsAssignment.src.Bildirim;
using DesignPatternsAssignment.src.Indirimler;

namespace DesignPatternsAssignment.src
{
    public class Cart
    {
        public List<string> urunler = new List<string>();
        public List<double> fiyatlar = new List<double>();


        public void UrunEkle(string urunAdi, double fiyat)
        {
            SepetBildirim bildirim =
new SepetBildirim();

            bildirim.BildirimGonder();

            urunler.Add(urunAdi);
            fiyatlar.Add(fiyat);

            Console.WriteLine(urunAdi + " sepete eklendi.");
        }


        public double ToplamFiyatHesapla()
        {
            double toplam = 0;

            for (int i = 0; i < fiyatlar.Count; i++)
            {
                toplam += fiyatlar[i];
            }

            return toplam;
        }


        public double IndirimHesapla(string indirimTuru)
        {
            double toplamFiyat = ToplamFiyatHesapla();

            IndirimFactory factory = new IndirimFactory();

            IIndirim indirim = factory.IndirimOlustur(indirimTuru);

            if (indirim != null)
            {
                double indirimMiktari =
                    indirim.Hesapla(toplamFiyat);

                return toplamFiyat - indirimMiktari;
            }

            Console.WriteLine("İndirim bulunamadı");

            return toplamFiyat;
        }
    }
}