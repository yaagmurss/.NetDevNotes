***.Net***
- Microsoft tabanlı
- Çoklu dil desteği (F# C# vb.net)
- Open Source

***API***
- Application Programming Interface 
- API, iki yazlımsal ürünün birbiriyle iletişime geçmesini sağlayan bir arayüz
- API platform bağımsızdır

***REST***
- Representational State Transfer
- İstemci-sunucu arasında hızlı ve kolay şekilde iletişim kurulmasını sağlayan bir servis yapısıdır
- HTTP üzerinde çalışır 
- Basittir, hızlıdır
- REST standartlarına uygun yazılan web servislerine RESTful servisler denir
- Xml + json

***SOAP***
- Simple Access Protocol  
- XML formatındadırlar

***URL***

![image](https://user-images.githubusercontent.com/52479605/211392535-fd9cd623-e2dc-400b-ab31-1d16e01c36cd.png)

***Http vs Https***
- Hypertext Transfer Protocol 
- HTTP güvensizdir fakat HTTPS güvenlidir
- HTTP de hiç bir şifreleme yoktur. HTTPS de veriler gönderme ve almadan önce şifrelenir
- HTTP durumunda sertifikaları doğrulama için gerekmez. HTTPS SSL Dijital Sertifika gerektirir.

***HttpStatusCode***
- 200 — Successful responses		
- 300 — Redirection
- 400 — Client errors
- 500 — Server errors
 ...

***HttpVerbs***
- Delete
- Get
- Head
- Options
- Patch
- Post
- Put

***Return Types*** 
- void
- Specific Types : can return string or a custom entity.
- IActionResult : can return an HTTP status code.
- ActionResult<T> : can return specific status code

***Model Kavramı ( Entity - dto )***
- Veri tabanındaki tablolarını nesne hali

***Access Modifiers***
- public: hiçbir kısıtlama yok
- protected: sadece tanımlandığı class’ın içinde ve o class’tan türetilmiş diğer class’ların içinde erişilebilirdir
- internal: internal olarak tanımlanan öğe, bulunduğu assembly’nin (Dll veya Exe dosyası) içinde erişilebilirdir
- protected internal: protected internal erişim belirleyicisi, protected ve internal erişim belirleyicilerinin VEYA (OR) işlemiyle birleştirilmiş halidir
- private: private olarak tanımlanan öğe, sadece tanımlandığı class’ın içerisinde erişilebilirdir
- private protected:  private ve protected erişim belirleyicilerinin VEYA (OR) işlemiyle birleştirilmiş halidir


***Model Validations*** 
- IsModelValid methodu kullanılır
- Diyelim ki post edilen data gereklilikleri karşılamıyor. Data valid değildir

***Controller - BaseController***
- Asp.net de yeni bir controller ekledğimizde controller sınıfından türer
- Veri akısını kontrol eder

***Routing***
- Routing, route sıklıkla ağ sistemlerinde kullanılan ve rota, yönlendirme gibi anlamlara gelen bir terimdir
- ASP.NET MVC içerisinde yer alan routing yapısı gelen web isteklerini Controller ile eşleştirir


***Dependency injection***
- Bir sınıfın/nesnenin bağımlılıklardan kurtulmasını amaçlayan ve o nesneyi olabildiğince bağımsızlaştıran bir programlama tekniği/prensibidir.
- Yazılım içerisinde bulunan componentlerin “loosely coupled” (gevşek bağlı) olmasıdır.
- Bağımlılık oluşturacak nesneleri direkt olarak kullanmak yerine, bu nesneleri dışardan verilmesiyle sistem içerisindeki bağımlılığı minimize etmek amaçlanır.
- Kod esnek değildir. Bakımı ve genişletilebilirliği zordur
- Bağımlılıklar Unit testi zorlaştırır.

***Singleton***
- Singleton ile oluşacak nesne örneği (instance) bir tanedir ve uygulama çalıştığı sürece aynı nesne kullanılmaya devam eder. Her istekte aynı nesne kullanılır. Startup.cs dosyasında AddSingleton metodu ile tanımlama yapılır.

***Scoped***
- Scoped ile her istekte yeni bir nesne örneğinin oluşması ve aynı istek boyunca bu nesne kullanılmaya devam eder. Eğer sayfa yenilendiğinde, yeni bir istek olacağı için yeni bir instance oluşturulur. Startup.cs dosyasında AddScoped metodu ile tanımlama yapılır.

***Transient***
- Transient ile oluşturulmuş nesnenin her seferinde tekrardan örneğinin oluşturulması sağlanır. Her enjekte edilmesinde veya istekte yeniden instance oluşturulur. Startup.cs dosyasında AddTransient metodu ile tanımlama yapılır.
	

***Json Web Token***
-  Jwt contains three different parts in it. First part is the header that keeps the hashing algorithm and token type. Second part is the payload that keeps the data but not user credentials. Data is carried by key and value pairs. Third part is a signature that can be symmetric or asymmetric. 	
	
	
***API Filters***
- Filtreler Action Method’un hemen üstünde Attribure olarak tanımlanır. Tanımlanan Filter ilgili Action Method için uygulanır.
- Action Filters
- Result Filters
- Authorization Filters
- Exception Filters
	
	
***In Memory Caching***
- Caching sık kullanılan dataları kaydetme tekniğine verilen isimdir.
- Kaydetme işlemi uygulamayı host eden sunucunun ram belleğinde(In Memory Caching) ve harici bir caching sunusunda(Distributed Caching) gerçekleştirilebilir.
- Tutabileceğimiz cache boyutu uygulama sunucusunun ram miktarıyla doğru olarantılıdır.
	
***Distributed Cache***
- Eğer uygulamamız birden fazla sunucu üzerinde çalışıyorsa In-Memory Cache yerine Distributed Cache kullanmak daha doğru olacaktır.
- Distributed Cache yönteminde, Cache dataları uygulamanın ayağa kalktığı host işletim sisteminin ram belleğinde tutulmaz. Bu yöntemde cache dataları ayrı bir cache service inde tutulur.

***Redis (Remote Dictionary Service)***
- NoSQL veritabanıdır. Veriyi bellekte tuttuğu için çok hızlı okuma ve yazma yapılır.
