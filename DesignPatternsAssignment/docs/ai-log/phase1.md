AI'a sorduğum prompt

Mevcut sistemde indirimler Cart sınıfının içinde if-else ile yönetiliyor. 
Yeni indirim eklemek için mevcut kodu değiştirmem gerekiyor.

Hangi tasarım örüntüleri düşünülebilir, kod nasıl daha düzenli hale getirilir? 
Kod review yapabilir misin?


AI YANITI (özet olarak)


Kodda temel sorunlar olarak Cart sınıfının fazla sorumluluk alması, yeni indirim eklemek için mevcut kodun değiştirilmesi 
ve if-else yapısının zamanla büyüyerek karmaşık hale gelmesi dikkat çekiyor.

Bu yapı küçük projelerde çalışabilir ancak sistem büyüdükçe bakım ve geliştirme açısından sorun çıkarabilir.

Bu nedenle Factory Method uygun görünüyor çünkü nesne oluşturma işlemlerini merkezi hale getirerek Cart sınıfını sadeleştirebilir.

Alternatif olarak Strategy de düşünülebilir ancak mevcut problem davranıştan çok nesne oluşturma ile ilgili olduğu için
Factory Method daha uygun bir başlangıç çözümü gibi duruyor.




NE UYGULADIM



Ben Factory Method kullanmayı tercih ettim.

İndirimleri ayrı sınıflara ayırdım:
- OgrenciIndirimi
- PremiumIndirimi
- YilbasiIndirimi
- OgretmenIndirimi

Daha sonra IndirimFactory oluşturdum ve indirim nesnelerini burada üretmeye başladım.



## AI ile farklı düşündüğüm nokta

AI Strategy Pattern önerisini de söyledi ancak bu aşamada onu kullanmadım.
Şu anki problem nesne oluşturma ile ilgili olduğu için önce Factory Method kullanmanın daha uygun olduğunu düşündüm.
