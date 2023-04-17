
	
***Kurumsal Mimaride Proje tasarımı***
- N-katmanlı (n-tier) mimari olarak da bilinir. Her katman farklı bir fonksiyonu yerine getirir ve genel olarak kendisinden bir alt ve bir üst katman ile iletişim kurar. 
	
**Model-View-Controller Tasarım Kalıbı***
- Kullanıcı ara yüzü tabanlı yazılımlarda çok yaygın olarak kullanılan Model-sunum-kontrolcü (Model View Controller-MVC) tasarım kalıbı bulunmaktadır.

***Mikro-Servis Mimarisi***
- Mikroservis mimarisinin yaptığı, uygulamamızı olabildiğince ufak ve kendi database’ine sahip servislere bölmek ve bu şekilde çalıştırmaktır.
- Servisler birbirinden bağımsız şekilde yüklenebilir. 
- Bir servis istenmeden kapandığında diğer servisleri etkilemez. 
- Kritik servisler birden fazla kopya çalıştırılarak genişleyebilen yapı sağlanır. 
- Projenin ileri ki aşamalarında geliştirilecek yeni servisler tamamen farklı bir programlama dili ve kütüphane seti ile geliştirilebilir.
- Servis ne kadar küçük olursa, mikroservis mimarisinin faydalarını en üst düzeye ve olumsuz etkilerini de en alt düzeye indirmiş oluruz.
-  Çoklu, işbirliği yapan mikro servislerden oluşan bir sistemle, her birinin içinde farklı teknolojiler kullanmaya karar verebiliriz. Bu, her bir iş için doğru aracı seçmemize olanak tanır. 
- Ayrıca ekibe sonradan katılan bir kişinin bu kadar büyük bir yapıya, mimariyi öğrenmesi yerine, bu kişinin hangi dilde ve hangi DB ortamında işi yapmasını biliyor ise bu ortamda bu ufak iş mantığını geliştirme imkanı vermeyi sağlar. 
-  Mikroservis mimarisi ile bağımsız servisler küçük boyutlarda olduğundan, bunların yerine daha iyi bir uygulama ile yer değiştirme, dönüştürme ya da bunları tamamen silme maliyetini yönetmek daha kolaydır.  
- Mikroservis yaklaşımlarını kullanan ekipler, gerektiğinde hizmetlerin tamamen yeniden yazılabilmesinde ve artık ihtiyaç duyulmadığında bir servisi yok etmekte eskiye kıyasla sıkıntı yaşamazlar. 
	
***Clean Code Principles***
- Düzgün klasörlenmiş sınırları belli bir dosya yapısı oluşturulmalıdır.
- İsimlendirmeye önem verilmelidir.
- Class İsimlendirmeleri : Tanımlayacağınız classın single responsibilty prensibine uygun olması ve isminin de bu single responsibility’i net bir biçimde yansıtıyor olması gerekir. İyi isimlendirilmiş classlar genelde isim olarak bir fiil değil bir isim alırlar.
- Method İsimlendirmeleri : Metotlar bir fonksiyonelliği yerine getirdiklerinden isimleri ‘fiil’ olmalıdır. Metotlar da classlar gibi single responsibilty prensibine uymalı ve sadece tek bir fonksiyonelliği yerine getirmelidir. Metot isimlendirmesinde And, If, Or, gibi bağlaçlar geçiyorsa orada durup metot birden fazla işi içerisinde barındırıyor mu diye bir düşünmeniz gerekli.
- Kısaltma kullanımı : İsimlendirmelerde kısaltma kullanımı kodlamada yapılan en büyük yanlışlardandır
- Boolean isimlendirmeleri : İyi bir boolean isimlendirmesi okuyucuya sanki cevabı “doğru” veya “yanlış” olan bir soru soruyormuş gibi olmalıdır.
- Conditionlar : Booelan bir değeri condition içerisinde tekrar true ya da false’a eşitlemek gerek olmayan bir kalabalık yaratacaktır onun yerine aşağıdaki kullanımı tercih etmeliyiz.
- Bir grup seçenek arasından seçim yapacaksak bunu static olarak vermektense enumlara bağlayıp kullanmak daha yerinde olacaktır. Böyleyce kodda ilgili bir opsiyonu değiştirmek istediğimizde, o opsiyonun kullanıldığı yerleri tek tek bulup değiştirmek yerine, ilgili enum opsiyonunu değiştirmemiz yeterli olacaktır.
- Kodun içerisinde hiç bir anlam ifade etmeyen sayı, string gibi staticleri de direkt olarak kullanmamamız gerekir
- Fonksiyonlar :Kod tekrarından kurtulmak için ,Olabildiğince Küçük, yalnızca tek işlev, Niyeti net bir şekilde belli etmek, Parametre sayısı ikiden fazla olamamya özen gösterilmeli
	
***Pyramid of clean code***
- Continous Refactoring
- TDD TestDriven Development
- Desing Patterns
- Solid
	
***Solid Design Principles***
- Single Responsibility Principle (SRP) : Bir sınıfı en fazla 25 kelime ile anlatabiliyor olmalısınız, ve yada veya kullanmadan.	
- Open Closed Principle (OCP);  Classes, functions, or modules should be opened for extensibility, but closed for modification.
Each new feature should not modify existing source code. OCP principle was originally described in the context of Inheritance
A component should be extendable to make it behave in new ways.“Eğer bir şey ördek gibi görünüyor, onun gibi yüzüyor, ama pile ihtiyaç duyuyor ise, muhtemelen yanlış bir soyutlamaya sahipsiniz :).”	
- Liskov Substitution Principle (LSP); her bir alt sınıf, türetilmiş olduğu, temel sınıflar yerine kullanılabiliyor olmalıdır.
- Interface Segregation Principle (ISP);Birbirlerinden bağımsız birden fazla yeteneği tek bir Interface’de tutmak yerine, her yetenek farklı bir Interface yapısında tutulmakta ve ihtiyac doğrultusunda ilgili sınıfa ilgili arayüzler uygulanmaktadır.
- Dependency Inversion Principle (DIP);High-level modules should not depend on low-level modules. Both should depend on abstactions. Abstractions should not depend upon details. Details should depend upon abstractions.



***Nesneye yönelik programlamanın temel kavramları***
- Nesne (Object); Kendine has özellikleri olan ve özelliklere bağlı olarak belirli bir durumda bulunarak çeşitli tutumlar sergileyen somut ya da soyut varlıklardır.
- Sınıf (Class); Aynı türden nesnelerin oluşturduğu bir kümedir.
- Metot; Bir nesnenin yapabileceklerini belirleyen kavramdır.
- Kalıtım (Inheritance); Bir sınıfın belirli özellik ve tutumlarını bir üst sınıftan alarak, kendisi için farklı olan özellik ve tutumları ayrıca uyguluyor olmasıdır.
- Soyutlama (Abstraction); Nesnenin uygulama için gerekli olan özelliklerinin kodlanarak, diğer özelliklerinin kodlanmaması anlamına gelir.
- Çok biçimlilik (Polymorphism); Nesnelerin kendi türlerinin dışında farklı türler olarak da temsil edilmelerini sağlar.
- Kapsülleme (Encapsulation); Nesnenin yaptığı işler ve durumuyla ilgili bilgilerin ve işlevsel karmaşıklığının gizlenmesi anlamına gelir.


***SOLID prensipleri***

- Single Responsibility: Bir nesnenin sadece bir sorumluluğu olmalıdır.
- Open Closed: Nesne genişlemeye açık, değişikliğe kapalı olmalıdır.
- Liskov's Substitution: Nesneler, programın çalışmasında sorun yaratmadan kendi alt örnekleriyle değiştirilebilmelidir.
- Interface Segregation: Nesneler ihtiyaç duymadıkları metotların Interface'lerinden ayrıştırılmalıdır.
- Dependency Inversion: Yüksek seviyeli sınıflar, düşük seviyeli sınıflara bağlı olmamalı, her ikisi de soyut kavramlara bağlı olmalıdır.



***Library (Kütüphane)***
- Önceden yazılmış hazır metotların olduğu alandır. Projeye dahil edilerek kullanılır.


***Framework (Çatı)***
- Önceden hazırlanmış kütüphanelerin bulunduğu bir iskelettir. Proje o iskelete göre inşa edilebilir.


***Interface***
- İçinde sadece kendisinden türeyen sınıfların içini doldurmak zorunda olduğu içi boş metot tanımlarının yapıldığı bir yapıdır. Bir nevi sözleşme gibidir.


***Abstract***
- İçinde içi dolu metotların, değişkenlerin ve boş metotların tanımlanabildiği yapılardır. Ortak özellikleri bulunan nesneleri tek bir çatı altında toplayıp kod tekrarını azaltmak için kullanılır.


***Compiler (Derleyici)***
- Herhangi bir programlama dilindeki kaynak kodları makine diline çeviren uygulamadır.


***HTTP***
- İnternette sunucular ve son kullanıcılar arasında bilgilerin nasıl aktarılacağına dair kuralları ve yöntemleri düzenleyen sistemdir.


***Authentication***
- Kullanıcının kimliğini kontrol etmektir. Sisteme giriş yapmak için kullanılır.

***Authorization***
- Kullanıcının kaynaklara erişimini doğrulamaktır. Sistemde işlem yapmak için kullanılır.


***MVC**

- Model, View ve Controller kelimelerinin kısaltmasıdır.
- Model; Verileri temsil eden kısımdır.
- View; Kullanıcının gördüğü arayüzdür.
-Controller; Projedeki veritabanı işlemleri, hesaplamalar gibi her şeyin kontrol edildiği bölümdür.


***API***
- Herhangi bir uygulamanın belli işlevlerini diğer uygulamalarında kullanabilmesi için oluşturulan modüldür.


***SOAP***
- Simple Object Access Protocol'ün kısaltmasıdır. Türkçe olarak Basit Nesne Erişim Protokolü anlamındadır. İnternet üzerinden küçük miktarda bilgileri aktarma protokolüdür. Veriler genelde HTTP, bazen de TCP/IP ile gönderilir. XML formatındadır. XML kullanmaya mecbur bırakır.


***REST***
- İstemci ve sunucu arasında veri alışverişinin basit bir yoludur. JSON, XML, Text gibi formatlarda veri alışverişi yapılabilir. HTTP ile gönderilir. SOAP'a göre daha hızlı çalışır.


***Middleware***
- Örneğin bir Rest Api tasarlıyoruz. Token ile authentication işlemlerini hallediyoruz. Token gerektiren birkaç tane Api yazdık. Bu Api'lere gelen isteklerde Token'ın geçerliliğini kontrol etmek adına bir Middleware oluşturabiliriz. Böylece gelen istek Middleware'daki kontrolden geçemezse direkt olarak kesilir. Geçerse yoluna devam eder.


***Lazy Loading***
- Bir kod bloğu, nesne veya program parçasının sadece ihtiyaç duyulunca çalıştırılmasıdır.


***SSL***
- Sunucu ve istemci arasında verilerin şifrelenerek gönderilmesidir.


***FTP***
- Bir bilgisayardan başka bir bilgisayar ya da sunucu arasında bağlantı kurup dosya paylaşma protokolüdür.

***Access Modifiers***
- Sınıflara, nesnelere, metotlara vs. proje içerisinde nerelerden erişilebiliceğini tanımlayan kavramlardır.
- Public; Proje içerisinde herhangi bir yerden erişilebilir.
- Protected: Bulunduğu sınıf ve ondan türetilen diğer sınıflardan erişilebilir.
- Private: Sadece bulunduğu sınıf üzerinden erişilebilr.


***Coupling ve Cohesion***

- Coupling; Sınıfların birbiriyle olan bağımlılığıdır. İyi bir yazılım için Coupling'in en aza indirilmesi önerilir. 
- Cohesion; Bir sınıfın oluşturulma amacını ne kadar temsil ettiğidir. İyi bir yazılım için Cohesion'ın yüksek oranda olması önerilir. Örneğin matematik işlemi yapan bir sınıfta dosya işlemi olmamalıdır.