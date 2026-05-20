namespace DesignPatternsAssignment.src
{
    public class Cart
    {
        public List<string> urunler = new List<string>();
        public List<double> fiyatlar = new List<double>();


        public void UrunEkle(string urunAdi, double fiyat)
        {
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

            else if (indirimTuru == "ogretmen")
            {
                indirimMiktari = toplamFiyat * 5 / 100;
            }

            else
            {
                Console.WriteLine("İndirim bulunamadı");
            }

            return toplamFiyat - indirimMiktari;
        }
    }
}