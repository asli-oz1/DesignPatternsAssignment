

Benim fark ettiğim tasarım hataları :

1) Yeni bir şey eklendiğinde mevcut kod değiştiriliyor
Yeni indirim eklemek veya bir indirimi kaldırmak istediğimde mevcut kodun içine girip değişiklik yapmak gerekiyor.

2) Cart sınıfı yapıyor tüm işleri tek başına yapıyro.
Cart sınıfı ürün ekleme, fiyat hesaplama ve indirim işlemlerini kendi başına yapıyor.

3) Bazı işlemler tekrar ediyor
İndirim hesaplamalarında benzer işlemler tekrar tekrar yazılıyor. 
İndirim sayısı arttıkça kod daha da uzayabilir.

4) Yeni indirim türü eklemek zor
Yeni bir indirim eklemek için tekrar if bloğu yazmak gerekiyor. 
Yeni kampanyalar eklenmek istenirse uğraştırıcı olabilir.

5) Çok fazla if-else kullanılıyor
İndirimler if-else ile kontrol ediliyor.
Kod büyüdükçe okunması ve düzenlenmesi zorlaşabilir.

AI YANITI :

## 1) Çok fazla if-else kullanımı

İndirim türleri if-else bloklarıyla kontrol ediliyor. İndirim sayısı arttıkça kod uzayacak ve yönetilmesi zor hale gelecektir.

Önerilen örüntü: Strategy Pattern
Her indirim türü ayrı bir sınıf haline getirilebilir. Böylece yeni indirim eklemek için mevcut kod değiştirilmez.

## 2) Cart sınıfı çok fazla sorumluluk üstleniyor

Cart sınıfı ürün ekleme, toplam fiyat hesaplama, indirim hesaplama ve çıktı verme işlemlerini aynı anda yapıyor.

Önerilen örüntü: Facade veya Strategy Pattern
Sorumluluklar ayrı sınıflara bölünerek sistem daha düzenli hale getirilebilir.

## 3) Yeni özellik eklemek mevcut kodu değiştirmeyi gerektiriyor

Yeni bir indirim eklendiğinde mevcut if-else yapısına müdahale etmek gerekiyor.

Önerilen örüntü: Factory Method
İndirim nesneleri merkezi bir yapıdan üretilebilir. Böylece nesne oluşturma işlemi tek yerde toplanır.

## 4) Kod tekrarına açık bir yapı var

İndirim hesaplamalarında benzer işlemler tekrar ediliyor. Sadece oranlar değişiyor.

Önerilen örüntü: Template Method veya Strategy Pattern
Ortak işlemler tek bir yapıya alınabilir, değişen kısımlar ayrılaştırılabilir.

## 5) Veriler çok düzenli tutulmuyor

Ürün isimleri ve fiyatlar iki farklı listede tutuluyor. İleride veri karışıklığı oluşabilir.

Önerilen çözüm: Product sınıfı oluşturulabilir
Ürün bilgileri tek nesne altında toplanabilir.

## 6) Sistem genişletilebilir görünmüyor

İleride kampanya, kupon veya farklı indirim türleri eklendiğinde mevcut yapı hızlı şekilde karmaşıklaşabilir.

Önerilen örüntü: Decorator Pattern
Mevcut sistemi değiştirmeden yeni özellikler eklemeyi kolaylaştırabilir.

Bu kod küçük ölçekte çalışıyor olsa da proje büyüdükçe bakım ve geliştirme sürecinde zorluk çıkarabilecek bazı tasarım problemleri içeriyor.



BENZERLİKLER


Benim fark ettiğim tasarım hataları daha çok görünen taraf ile ilgiliydi. Kod fazlalıkları ve genel dağınıklık
her şeyin aynı alanda yönetilmesi dikkatimi çeken kısım oldu. AI da benzer sorunları fark etti. 
Ancak AI daha çok tasarım prensipleri açısından değerlendirme yaptı. 
Ben daha çok kodun karmaşıklaşması ve tekrar eden yapılar üzerine düşündüm. 
AI ise mimari tarafına ve ileride oluşabilecek sorunlara daha fazla odaklandı.
Genel olarak benim bulduğum problemler ile AI'ın söyledikleri büyük ölçüde benzerdi. 
Ancak AI bazı teknik noktaları daha iyi analiz etti.

