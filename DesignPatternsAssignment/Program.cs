using DesignPatternsAssignment.src;

Cart sepet = new Cart();

double sonuc = sepet.IndirimHesapla(1000, "ogrenci");

Console.WriteLine("İndirimli fiyat: " + sonuc);