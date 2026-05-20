using DesignPatternsAssignment.src;

Cart sepet = new Cart();

sepet.UrunEkle("Kulaklik", 3000);
sepet.UrunEkle("Mouse", 1000);
sepet.UrunEkle("Klavye", 2000);

Console.WriteLine("Toplam fiyat: " + sepet.ToplamFiyatHesapla());

double sonuc = sepet.IndirimHesapla("ogrenci");

Console.WriteLine("İndirimli fiyat: " + sonuc);