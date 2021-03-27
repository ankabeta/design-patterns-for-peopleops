# design-patterns-for-peopleops
# The Catalog of Design Patterns
# Desing Patterns
  İnsanoğlu olarak yaşam boyunca birçok problemlerle karşılaşmış ve bunlara kendimizce çözümler üretmişizdir. Bazen bu çözümler önceki çözümlerimize o kadar tanıdık gelmeye başlar ki, bu durum artık kendini tekrar etmeye başlar. Belli süre sonra artık geçmiş hatalarımızdan dersler alırız ve bir sonraki adımda aynı problemle karşılaşmamak için yapılması gerekeni biliriz.
Yazılım sektörünün gelişiminde de bu durum söz konusu. Biz yazılımcılar aslında farklı projeler geliştiriyor olsak da benzer problemlere çözüm ararız, benzer sorunlarla karşılaşırız. Bu sorunlara da hepimiz kendimizce çözümler üretiriz. Peki bu çözümleri bir araya getirsek ve bunlara bir isim versek? İşte Design Patterns(Tasarım Kalıpları) buna çözüm sunuyor.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/1_1.png)
 
Design patternler, bir yazılım projesinden sıklıkla karşılaştığımız benzer sorunlar üzerinden yola çıkarak Code Optimization'ı en iyi şekilde yapabilmemizi sağlayan yapılardır. Elbette ki bu yapılar bizden önce benzer problemlerle daha önce karşılaşmış olan, uzun uğraşlar ve incelemeler sonunda en optimize şekilde nasıl bir çözüm getirebiliriz düşüncesinde olan kişiler tarafında bulunmuştur ve hepsi de kullanılabilirlik, uygulanabilirlik açısından oldukça iyidirler. Aslında iyi demek yetmez biz bilgisayar mühendislerinin ve diğer bütün yazılım alanında çalışan herkesin hayatını ciddi bir biçimde kolaylaştırmıştır.<br/>
<br/>
• İyi bir yazılımı etkili bir şekilde nasıl tasarlayabiliriz?<br/>
• Geçmiş tecrübelerimizi, gelecek projelerimize nasıl aktarabiliriz?<br/>
• Yazılımın tasarımı esnasında, esneklik ve verimlilik gibi iyi özelliklere nasıl sahip olabiliriz?<br/>

Soruları bizleri desing patternleri bulmaya ve kullanmaya götürmüştür.

Tasarım kalıpları bir algoritma ya da kod değildir. Ayrıca belli dile özgü değildir, dilden bağımsızdır. Genellikle nesneler arası ilişkileri UML diyagramları ile gösteririz, bu sayede yazılımcılar arasında ortak bir iletişim dili oluşmuş olur. Belli bir tasarımı istediğiniz dille yazdığınız bir projeye kolaylıkla uygulayabilirsiniz. Tabi burada bir yanlış anlaşılmayı gidermekte fayda var. Neredeyse tüm Türkçe kaynaklarda tasarım kalıplarını OOP(Nesne Tabanlı Programlama) ile sınırlandırmışlar. Ancak Tasarım Kalıpları, dilden ve programlama paradigmalarından bağımsızdır. Yani farklı bir paradigma için de çözümler üretilebilir. Günümüzde en yaygın ve projelerde en çok kullanılan paradigma OOP olduğu için tasarım kalıpları diyince direk OOP çözümleri akla gelmekte.

## Tasarım Kalıpları Çeşitleri
Yazılım tasarım kalıpları genel olarak 3 ana başlıkta incelenir. Bunlar şunlardır:
 
![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/1_2.png)

### 1.	**Creational design patterns**
Nesnelerin nasıl yaratılacağı hakkında öneriler sunar. <br/>

  •	Abstract Factory  <br/>
  •	Builder <br/>
 	•	Factory Method <br/>
  •	Prototype <br/>
  •	Singleton <br/>


### 2.	**Structural design patterns**
Sınıflar arasındaki ilişkileri belirleme önerileri sunar, Nasıl türetilmeli, hangi nesneleri içermeli, sınıflar birbirlerini nasıl bağlı olmalı gibi soruların cevaplarını yanıtlar.<br/>

•	Adapter <br/>
•	Bridge <br/>
•	Composite Decorator <br/>
•	Facade <br/>
•	Flyweight <br/>
•	Proxy <br/>



### 3.	**Behavioral design patterns**
Soruna göre nesneler arası ortak haberleşmeyi en iyi şekilde kurmamıza öneriler sunar.<br/>

•	Chain of Responsibility <br/>
•	Command <br/>
•	Interpreter <br/>
•	Iterator 	<br/>
•	Mediator <br/>
•	Observer <br/>
•	State <br/>
•	Strategy <br/>
•	Template Method <br/>
•	Visitor <br/>

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/1_3.png)

# Refactoring 
Yazılan kodların üzerinden zaman geçtikten sonra (6–7 ay bile yeterlidir), hangi scriptin ne ifade ettiği unutulabilir. Dolayısıyla anlamak için kodu okumak gerekir. Kod ne kadar karışıksa, yapılan işi anlamak da o kadar zorlaşır. Dolayısıyla o kadar zaman alır. Dahası bir şirkette çalışıyorsak, başkasının kodlarını okumamız da gerekecektir ve kodlar karışıksa bu durumun içinden çıkmak iyice zorlaşacaktır.
Refactoring, yazılımı daha basit, daha anlaşılır, değiştirmesi daha kolay bir hale getirmek amacıyla iç yapısında yapılan ve yazılımın dış davranışını etkilemeyen değişikliklerdir. Evet refactoring bir süreçtir. Her ne kadar amaç/niyet her zaman en baştan temiz kod yazmak olsa da (her ne kadar yazarken en temiz şekilde yazılsa da) değişen ve gelişen kodların zaman içerisinde sürekli optimize edilmesi gerekecektir.
Amaç **temiz kod** yazmak. Programlama bilgisayara ne yapması gerektiğini söylemektir. Zamanla daha iyi bir yazılımcı olursunuz ve bilgisayara anlattığınız şey ile gerçekten istediğiniz şey gittikçe birbirine daha çok yaklaşır. Bu yüzden her geçen gün daha temiz kod yazarsınız. Refactoring kavramı bize aylar önce yazdığımız kodun kolay okunabilir olmasını ve zorlanmadan kod üzerinde değişiklikler yapmamızı sağlar. Elbette bu değişiklikleri biz değil başkaları da yapabilir.
Tabiki bunun dışında da faydaları var. Refactoring sayesinde iyi bir **yazılım tasarımı** (software design) yapmanız kolaylaşır. Neredeyse hepimizin ezbere bildiği ama pratikte kullanmakta çok zorlandığı **tasarım desenlerini** (design patterns) kolaylıkla kullanabilmenizi sağlar. Çünkü kod temiz ve düzenlidir ve artık görmekte zorlandığınız incelikleri kolaylıkla görmeye başlarsınız.

**Peki ne zaman kullanılabilir?**

Aslında refactoring kavramı sürekli kullanılması gerekiyor gibi görünse de refactoring’i kullanmak için belli başlı kurallar vardır. Bunları temel olarak 3 başlıkta toplayabiliriz
1.	**Yazılıma yeni bir fonksiyonalite eklediğinde:** Yeni bir özellik eklediğinizde epey kod yazarsınız ve bu kodun refactor edilmesi gerekir. Kent Beck’in şapka teorisine bakarsak. Kendisi 2 şapkanız olsun der, biri koder şapkası, diğer refactorer şapkası. Yeni bir özellik eklerken koder şapkasını takın ve sadece o özelliği eklemeye odaklanın, sadece kod yazın. Refactor yapmayı düşünmeyin. Özelliğin eklendiğine ve çalıştığına inandığınız anda koder şapkasını çıkarıp refactorer şapkasını takın ve yazdığınız kodu design etmeye başlayın. Mükemmel design’a ulaşmaya çalışmak kötü bir şeydir ve genelde şeytan vesvesesidir, “iyi” bizim için yeterli. İyi olduğunu düşündüğünüzde davranışın değişmediğini test edin.
 
2.	**Yazılımdaki bir hata giderildiğinde:** Bir hatayı çözmeye çalışırken de kodu okumanız gerekir. Eğer okuyamıyorsanız okunabilir hale getirmekten çekinmeyin.
 
3.	**Yazılımı gözden geçirirken:** Birçok şirket bunu yapmasada, büyük ve kurumsal şirketlerde “code review” denen bir olay vardır. Biz de kurumda sık sık yapıyoruz ve code review sırasında aslında bana göre gayet okunabilir ve anlaşılır duran birşeyi arkadaşımın anlamadığını görebiliyorum. Çünkü anlaşılabilirlik subjektif bir kavram ve birden çok yazılımcının birlikte yaptığı bir code review sırasında refactor yapmak, bu subjektif kavramı mümkün olduğunca objektif hale getirir.

## Creational Patterns
**Singleton Pattern:** Singleton(tek nesne) tasarım kalıbı, bir sınıfın tek bir örneğini almak için kullanılır. Amaç oluşturulan nesneye global erişim noktası sağlamaktır. Böylece nesne dilendiği zaman dilenilen yerden erişilebilecektir. Sistem çalıştığı sürece ikinci bir örnek oluşturulmaz, böylelikle istenen nesnenin tek bir defa oluşturulması garanti altına alınacaktır. Tek bir defa oluşturulan nesne bellekte fazladan yer kaplanmamasını sağlar. Bu durumda daha optimize bir bellek yapısı elde ederiz. Singleton nesneler ilk çağırıldıklarında bir kere oluşturulurlar ve sonraki istekler bu nesne üzerinden karşılanır. 

 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/1.png)

Singleton Pattern ‘le alakalı bir önemli husus ise Thread Safe yöntemidir. Örneğin yapılan örnekte eğer nesne eğer boş ise yeniden oluşturup gönderilir. Bu yöntem bir soruna sebep olabilir; eğer bu nesneye birden fazla istek gelirse nesne sürekli oluşturulmaya çalışılacaktır böyle bir olayda sistem kilitlenebilir. Bunu engellemek için Thread Safe yöntemini kullanmalıyız. Bu yöntemle birden fazla aynı anda aynı Thread’e gelen istekleri sıraya alarak kontrollü bir yapı sağlamaktayız. Sayfamıza birden fazla gelen istekleri kontrol etmemize olanak sağlamaktadır.
Burada Lock parametresini kullanarak nesne daha önceden oluşturulmuş ise oluşturulan nesneyi geri göndererek işlem sağlıyoruz. Böylece nesne tekrardan oluşturulmaya çalışılmıyor. Eğer kilitleme yapılmazsa iki farklı thread’in ard arda yapacağı istek sonucu, birinin sonucuna ulaşamadan yeni bir örneklendirme yapar.
```
namespace Singleton
{
    /*
     * Singleton sınıfı, oluşturucuya alternatif olarak hizmet veren ve istemcilerin bu sınıfın aynı örneğine defalarca erişmesine izin veren "GetInstance" yöntemini tanımlar.
     */
    class Singleton
    {
        // Singleton Constructor'ları, "yeni" operatörle doğrudan Construc çağrılarını önlemek için her zaman özel olmalıdır.
        private Singleton() { }

        /*
         * Singleton örneği statik bir alanda saklanır. 
         * Bu alanı başlatmanın birçok yolu vardır, hepsinin çeşitli artıları ve eksileri vardır. 
         * Bu örnekte, bu yolların en basitini göstereceğiz, ancak bu, 
         * çok iş parçacıklı programda pek işe yaramaz.
         */

        private static Singleton _instance;


        /*
         * Bu, tekil örneğe erişimi kontrol eden statik yöntemdir. 
         * İlk çalıştırmada tekil bir nesne oluşturur ve onu statik alana yerleştirir. 
         * Sonraki çalıştırmalarda, statik alanda depolanan istemcinin mevcut nesnesini döndürür.
         */

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }

        // Son olarak, herhangi bir singleton kendi örneğinde yürütülebilecek bazı iş mantığını tanımlamalıdır.
        public static void someBusinessLogic()
        {
            // ...
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri kodu.

            Singleton s1 = Singleton.GetInstance();
            Singleton s2 = Singleton.GetInstance();

            if (s1 == s2)
            {
                Console.WriteLine("Eğer her 2 değişkende aynı örneği içeriyorsa Singleton çalışıyor. ");
            }
            else
            {
                Console.WriteLine("Eğer her 2 değişkende aynı örneği içermiyor farklı değerlere sahipse Singleton çalışıyor.");
            }
        }
    }
}
```


 

**Builder Pattern:** Creational Design Pattern’lerden birisi olan Builder pattern, haliyle diğer Creational Desing pattern’ler gibi bir nesne yaratma problemini çözmek üzere karşımıza çıkıyor. Builder Pattern güncük hayatta inşaat kavramıyla çok benzeştiriliyor. Nasıl ki biz bir bina yaparken bazı nesnelerin üretimleri ya da değiştirilmek istenirken oldukça maliyetli olabiliyorken aynı durum Builder D.P.’de de geçerlidir. İşte bu tarz inşa durumlarında Builder D.P. ile ilgili nesneler genişletilebilir bir hale getirilmekte ve en önemlisi kod karmaşıklığı minimize edilmektedir. Özetle üretim karmaşıklığına çözüm oluyor.

 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/2.png)
 
“Builder”, “ConcreteBuilder”, “Product” ve “Director” isminde dört adet terimimiz mevcuttur. 

**Product**
İnşa sonucunda elde etmek istediğimiz nesnemizdir.  ConcreteBuilder sınıfı tarafından üretilmektedir.

**ConcreteBuilder**
Gördüğünüz gibi Product ismini verdiğimiz nesneyi oluşturmaktadır. Oluşturulacak Product’ın temel özellik ve donanımını sağlayan sınıftır.

**Builder**
Product nesnesinin oluşturulması için gerekli ara yüzü sağlar. Burada ki önemli hususlardan birisi  ConcreteBuilder nesnesi ile kalıtsal bir durum söz konusu olmasıdır.

**Director**
Yaptığımız tasarım sonucunda bir Builder referansı üzerinden Client tarafından nesne üretim talebine cevap verir.

Bir örnek üzerinden anlatmamız anlaşıla bilirliği artıracaktır. Örneğin online bir araba satıcı fiması olalım.  Üretilen arabaları satmak istediğimiz için product sınıfımız araba olacaktır. Arabayı üretecek, temel özelliklerine ve donanımına karar verecek olan firma ise ConcreteBuilder’dır.  Satacağımız arabaların belirli özelliklerini belirleyip, sırası geldikçe uygulanmasını isteriz. 

```
namespace BuilderDesingPattern
{
    #region
    //Product Class
    //ConcreteBuilder Sınıfı tarafından üretilen product nesnemizin özellik tanımlarını burada belirtiyoruz.
    class Araba
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public double KM { get; set; }
        public bool Vites { get; set; }
        public decimal Fiyat { get; set; }
        public int Kapi { get; set; }
        public string Tavan { get; set; }
        public override string ToString()
        {
            return $"{Marka} marka araba {Model} modelinde {KM} kilometrede {Vites} vites olarak üretilmiştir. {Kapi} Kapılı ve {Tavan} tavandır. Yeni yıl indirimiyle beraber {Fiyat} fiyatındadır. ";
        }
    }
    #endregion
    #region
    //Builder
    abstract class IArabaBuilder // Abstract sınıf temel bir sınıftır ve new komutu ile sınıf oluşturulamaz.
    {
        protected Araba araba; // Burada Araba protected olarak tanımlanmıştır. Sebebi sınıf içerisinde protected olarak işaretlenen bir eleman sadece o sınıf içinden yahut
                              // o sınıftan kalıtım alan sınıflar içerisinden erişilebilir olmasıdır.
                             // Yani o classın instanceı için private, o sınıftan türeyen sınıfların ve o sınıf içinde ise public özellik göstermektedir.
        public Araba Araba
        {
            get { return araba; }
        }

        public abstract void SetMarka();
        public abstract void SetModel();
        public abstract void SetKM();              // Builder arayüzünün görevi nesnesinin oluşturulması için gerekli arayüzü olmasıdır.
        public abstract void SetVites();           // ConcreteBuilder ile aralarında kalıtsal durum söz konuısudur.
        public abstract void SetFiyat();
        public abstract void SetKapi();
        public abstract void SetTavan();



    }
    #endregion
    //ConcreteBuilder Class
    // Burada nesnemizin temel özelliklerini belirleriz.
    #region
    class MercedesConcreteBuilder : IArabaBuilder
    {
        public MercedesConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 950;
        public override void SetMarka() => araba.Marka = "Mercedes"; // oveerride yapısı kullanıldığı görülmektedir. Bunun nedeni Override yapıları ile miras aldığı metotları ezerler ve 
                                                                    // Mevcut metodun yerine aynı isimli olan, diğer metodu çalıştırırlar.
        public override void SetModel() => araba.Model = "A180";
        public override void SetVites() => araba.Vites = true;
        public override void SetFiyat() => araba.Fiyat = 327000;
        public override void SetKapi() => araba.Kapi = 4;
        public override void SetTavan() => araba.Tavan = "Kapalı";
        
    }
    // ConcreteBuilder Class
    class TeslaConcreteBuilder : IArabaBuilder
    {
        public TeslaConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 1000;
        public override void SetMarka() => araba.Marka = "Tesla";
        public override void SetModel() => araba.Model = "Model 3";
        public override void SetVites() => araba.Vites = true;
        public override void SetFiyat() => araba.Fiyat = 785500;
        public override void SetKapi() => araba.Kapi = 2;
        public override void SetTavan() => araba.Tavan = "Kapalı";
    }
    //ConcreteBuilder Class
    class BMWConcreteBuilder : IArabaBuilder
    {
        public BMWConcreteBuilder()
        {
            araba = new Araba();
        }
        public override void SetKM() => araba.KM = 50;
        public override void SetMarka() => araba.Marka = "BMW";
        public override void SetModel() => araba.Model = "X6";
        public override void SetVites() => araba.Vites = true;
        public override void SetFiyat() => araba.Fiyat = 570000;
        public override void SetKapi() => araba.Kapi = 4;
        public override void SetTavan() => araba.Tavan = "Kapalı";

    }
    #endregion
    #region
    //Director Class
    class ArabaUret
    {
        public void Uret(IArabaBuilder Araba)
        {
            Araba.SetKM();
            Araba.SetMarka();
            Araba.SetModel();
            Araba.SetVites();
            Araba.SetFiyat();
            Araba.SetKapi();
            Araba.SetTavan();
        }
    }
    #endregion
    //Client
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciGiris;
            string kullaniciGelen;
          
                Console.WriteLine("Merhabalar uygunarabam.com'a Hoşgeldiniz.");
                Console.WriteLine("Yeni yılın gelmesi şerefine 3 araç ve modelde indirime gittik. ");
                Console.WriteLine("Kampanyamızı görmek ister misini? [E/H] ");
                kullaniciGiris = Convert.ToString(Console.ReadLine());
                kullaniciGelen = kullaniciGiris.ToUpper();
       
                if (kullaniciGelen == "E")
                {
                    IArabaBuilder araba = new MercedesConcreteBuilder();
                    ArabaUret uret = new ArabaUret();
                    uret.Uret(araba);

                    Console.WriteLine(araba.Araba.ToString());

                    araba = new TeslaConcreteBuilder();
                    uret.Uret(araba);
                    Console.WriteLine(araba.Araba.ToString());

                    araba = new BMWConcreteBuilder();
                    uret.Uret(araba);
                    Console.WriteLine(araba.Araba.ToString());

                }
                else
                {
                    Console.WriteLine("Kampanyalarımızdan haberdar olmak için yine gel! :) ");

                }

                Console.Read();



        }
    }
}

```

 

**Factory Pattern:** Factory desing pattern, creactional tasarım modlarından biridir. Bu tasarım deseni, nesneler oluşturmak için bir arayüz sağlar ve alt sınıfların hangi sınıftan bir nesne oluşturacağını belirlemesine olanak tanır. Temel amaç, oluşturmak istediğimiz sınıfın oluşturulma sürecini tek bir örnek oluşturmak yerine tek bir sınıf üzerinden yönetmektir. Örneğin kodumuzdaki yöntemlerde bazı durumlarda farklı tipte nesnelere ihtiyaç duyabiliriz. Elbette, bu nesneleri oluşturmak için if-else veya switch-case inşasını kullanabiliriz, ancak nesneler arttıkça, onları if-else veya switch-case bloğuna eklemek zaman, bakım ve kod açısından aynı değildir. Hoş bir durum. Ölçeklenebilirlik ve modülerlik. Bu durumda, Fabrika Yöntemi modelini kullanabiliriz.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/3.png)
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/4.png)
 
Yukarıdaki şablonları inceleyerek bir senaryo çizelim. Aşağıda benzer nitelikte farklı bir senaryo üzerinden Factory Method paternini uygulayacağız.

Yukarıdaki şablona göre elimizdeki birden fazla ürün interface tarafından türetilmektedir. Bu ürünleri abstract sınıf ile de türetebiliriz ki iki durumda da örneklendirme gerçekleştireceğiz.

İçerisinde geriye ilgili interface ya da abstract class tipinde değer geri dönen Factory işlemini gerçekleştirecek bir metod barındıran Creator sınıfımız mevcuttur. İstediğimiz ürünü oluşturabilmek için Creater tipinde bir nesne üzerinden Factory metodunu kullanmamız yeterli olacaktır. Factory metodu bize istediğimiz ürünün nesnesini oluşturacak ve interface ya da abstract class tipinde geri döndürecektir. Haliyle bizde interface ya da abstract class referansı üzerinden o nesneyi işaretleyebilecek ve gönül rahatlığıyla kullanabileceğiz.

Şimdi sıra pratik olarak Factory Method Design Patter’in nasıl yapıldığı üzerinde çalışmaya geldi. Hemen kurgulayacağım senaryoyu sizlerle paylaşmam gerekirse, ben bir oyun satıcısıyım ve “atari”, “pc” ve “ps” oyunları mevcut. Hadi gelin projemizi hemen dizayn edelim ve Factory Method paterni ile istediğimiz oyunu üretelim.
 
 ```
 namespace FactoryDesingPattern
{
    #region 
    // İstediğimiz nesneyi üretebilmek için program kurgumuz aşağıdaki gibidir.
    class Program
    {
        static void Main(string[] args)
        {
            Creater creater = new Creater();
            Oyun atariOyunu = creater.FactoryMethod(Oyunlar.Atari);
            Oyun pcOyunu = creater.FactoryMethod(Oyunlar.PC);
            Oyun psOyunu = creater.FactoryMethod(Oyunlar.PS);

            atariOyunu.Platform();
            pcOyunu.Platform();
            psOyunu.Platform();

            Console.Read();
        }
        #endregion


        #region
        // Kurgulanan senaryoya göre tüm ürünleri yani oyunları türetelim. abstract class’ı dizayn edelim.
        abstract class Oyun
        {
            public abstract void Platform();
        }

        #endregion

        #region
        // Ürünleri tasarlayalım ve oluşturmuş olduğumuz “Oyun” abstract class’ından bu ürünleri türetelim.
        class Atari : Oyun
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun ATARİ platformunda çalışmaktadır.");
            }
        }

        class PC : Oyun
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun PC platformunda çalışmaktadır."); // 3 Farklı class'ta oyun ürünlerinin classlarını oluşturduk.
            }
        }

        class PS : Oyun
        {
            public override void Platform()
            {
                Console.WriteLine("Bu oyun PS platformunda çalışmaktadır.");
            }
        }

        #endregion

        #region
        //FactoryMethod’u bize istediğimiz tipte nesneyi oluşturup gönderecek bir işleyişe sahip ama fakat bizim nasıl bir tipte nesne oluşturmak isteyeceğimizi bilemez.
        // Bizde bu sorunu Enumaration ile çözebiliriz.
        enum Oyunlar
        {
            Atari,
            PC,       // Yandaki Enumaration FactoryMethod’un hangi tipte nesne üreteceğine yardımcı olacaktır.
            PS
        }
        #endregion

        #region
        // Şimdi bu sınıflardan nesne üretecek olan Creater sınıfını oluşturmamız gerekiyor. Daha sonra içerisine Factory işlemini yapacak metodumuzu tanımlamalıyız.
        class Creater
        {
            public Oyun FactoryMethod(Oyunlar OyunTipi)
            {
                Oyun oyun = null;
                switch (OyunTipi)
                {
                    case Oyunlar.Atari:
                        oyun = new Atari();
                        break;
                    case Oyunlar.PC:
                        oyun = new PC();
                        break;
                    case Oyunlar.PS:
                        oyun = new PS();
                        break;
                }
                return oyun;
            }
        }
        #endregion

    }
}

 ```

**Abstract Factory Pattern:** Abstract Factory desing pattern, creactional tasarım modlarından biridir ve factroy desing’a çok benzer. Factory design pattern’de tek bir ürün ailesine ait tek bir arayüz mevcutken, abstract factory’de farklı ürün aileleri için farklı arayüzler mevcuttur. Yine isminden de yola çıkılabileceği üzere fabrika olarak düşünürsek, Factory DP sadece tek bir ürünün üretildiği fabrika, Abstract Factory DP ise farklı farklı ürünlerin üretildiği fabrika olarak düşünebiliriz.

•	Abstract Factory DP’ı birden fazla ürün ailesi ile çalışmak durumunda kaldığımızda, ürün ailesi ile istemci tarafını soyutlamak için kullanırız.

•	Abstract Factory DP ürün ailelerinin oluşumunu istemci tarafından ayırarak, karar verme koşulu olmadan, esnek ve geliştirilebilir bir yapı kurmamızı sağlar.

•	Client sınıfına, bir abstract arayüz kullanmasını sağlayarak, gerçekte üretilecek ilişkili Product sınıflarını bilmeden veya önemsemeden oluşturulmasına olanak tanır.

•	if-else yapısından kurtararak daha anlaşılır kod yazmayı sağlar.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/5.png)
 
Yukarıdaki bilgiler ışığında bir örnek yapalım. Örneğimizde ülkeyi seçtiğimiz taktirde bize o ülkenin en favori takımların birisinin renklerini ve ligin en skorer oyuncusunu veren bir uygulama yapalım. Bunun için class olarak ülke, takım ve futbolculara ihtiyacımız olacaktır. 
 
  ```
 namespace AbstractFactoryDesingPattern
{
    #region İnterface tanımlarımızı yapıyoruz. 

    public interface IPlayer
    {
        string GetTopScorer();
    }

    public interface ITeam          // Interface'leri amacı diğer classlara yön göstermektir. Bu yüzden Interface tanımları içerisinde kesinlikle kod bloğumuz bulunmaz.
                                    // Interface yapılar sadece tanımlamalardan ibarettir, içerisinde hiçbir yapıcı metod ekleyemeyiz.
    {
        string GetTeamColor();
    }

    public interface IFootballFactory
    {
        ITeam CreateTeam();
        IPlayer CreatePlayer();
    }

    #endregion

    #region IFootballFactory interface ini gerçekleyen ülke ve ülkelerin liglerini oluşturalım.
    public class TurkishLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Fenerbahce();
        }

        public IPlayer CreatePlayer()
        {
            return new TurkishligaPlayer();
        }
    }
    public class BundesLigaFactory : IFootballFactory 
    {
        public ITeam CreateTeam()
        {
            return new BorussiaDotmund();
        }

        public IPlayer CreatePlayer()
        {
            return new BundesligaPlayer();
        }
    }

    public class LaLigaFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new RealMadrid();
        }

        public IPlayer CreatePlayer()
        {
            return new LaLigaPlayer();
        }
    }
    public class SerieAFactory : IFootballFactory
    {
        public ITeam CreateTeam()
        {
            return new Juventus();
        }

        public IPlayer CreatePlayer()
        {
            return new SerieAPlayer();
        }
    }
    #endregion
    #region ITeam interface ini gerçekleyen takımları İçerisinde takıma ait renklerin string olarak döndüğü bir metot içeren halleriyle oluşturalım.
    public class Fenerbahce : ITeam
    {
        public string GetTeamColor()
        {
            return "Yellow and Navy blue";
        }
    }
    public class BorussiaDotmund : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and Yellow";
        }
    }
    public class Juventus : ITeam
    {
        public string GetTeamColor()
        {
            return "Black and White";
        }
    }
    public class RealMadrid : ITeam
    {
        public string GetTeamColor()
        {
            return "Blue and White";
        }
    }
    #endregion
    #region IPlayer interface’ini gerçekleyen Player class larımızı oluşturalım.
    public class TurkishligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Mesut Özil";
        }
    }
    public class BundesligaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Robert Lewandowski";
        }
    }
    public class LaLigaPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Lionel Messi";
        }
    }
    public class SerieAPlayer : IPlayer
    {
        public string GetTopScorer()
        {
            return "Cristiano Ronaldo";
        }
    }
    #endregion
    #region Altyapıyı bu şekilde oluşturduk diyebiliriz. Şimdi client class ımızı oluşturalım. Adına FootballWorld diyoruz.
        public class FootballWorld
    {
        private readonly IPlayer _teamScorer;

        private readonly ITeam _team;
        public FootballWorld(IFootballFactory factory)
        {
            _team = factory.CreateTeam();
            _teamScorer = factory.CreatePlayer(); 
                                                    // Görüldüğü üzere client class ının ne herhangi bir ülkeyle ne de herhangi bir takımla bağlantısı mevcut.
        }                                          // Tamamen soyutlanmış durumda.Ben hangi ülkeyi kullanmak istersem o ülkenin takımına ait rengi ve futbolcuyu bana dönecektir.

        public string GetFootballTeamColor()
        {
            return _team.GetTeamColor();
        }
        public string GetTopScorer()
        {
            return _teamScorer.GetTopScorer();
        }
       
    }
    #endregion
    #region
    class Program
    {
        static void Main(string[] args)
        {
            string user;
            string user1;

            IFootballFactory germany = new BundesLigaFactory();
            IFootballFactory spain = new LaLigaFactory();
            IFootballFactory italy = new SerieAFactory();
            IFootballFactory turkey = new TurkishLigaFactory();

            Console.WriteLine("Lütfen bilgi sahibi olmak istediğiniz takımın ülkesini giriniz.");
            Console.WriteLine("Germany for press G, Spain for press S, Italy for press I and Turkey for press T");
            user = Console.ReadLine();
            user1 = user.ToUpper();
            if (user1 == "G")
            {
                FootballWorld footballWorld1 = new FootballWorld(germany);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "S")
            {
                FootballWorld footballWorld1 = new FootballWorld(spain);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "I")
            {
                FootballWorld footballWorld1 = new FootballWorld(italy);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else if (user1 == "T")
            {
                FootballWorld footballWorld1 = new FootballWorld(turkey);
                Console.WriteLine(footballWorld1.GetFootballTeamColor());
                Console.WriteLine(footballWorld1.GetTopScorer());
            }
            else
            {
                Console.WriteLine("YANLIŞ BİR TIKLAMA YAPTINIZ! ");
            }

            Console.ReadLine();
        }
    }
    #endregion
}

 ``` 
  
**Prototype Design Pattern:**
Yazılım geliştirdiğimiz esnada maliyet bakımından yüksek olan nesneler olabilir. Maliyetten kasıt, çalışma zamanı ve bellek kullanımıdır. Bu nesnelerin daha efektif ve verimli kullanılabilmesi açısından prototype şablonu düşünülmüş. Bu şablon, var olan bir nesneyi klonlayarak bu problemin önüne geçmeyi hedefliyor. Dolayısıyla sürekli yeni nesne oluşturma aşamasındaki zahmetlere girmiyoruz. Yani sonradan da kullanılacağı düşünülen bir nesnenin prototip olması, diğerlerinin de bundan faydalanması isteniyor. Prototip olan nesne kopyalanıyor ve artık bu kopya üzerinden işlem yapılıyor. Böylece orijinal olan nesne de korunmuş oluyor.
Bu klonlama(kopyalama) işleminde, deep-copy yöntemi kullanılıyor. Yani bir nesne, birebir kopyalanarak yeni bir referans değişkene atılıyor.

Prototype tasarım deseninde 3 temel yapı vardır. Bunlar:

**Soyut prototip:** Kopyalanarak kullanılmak istenen nesneler için temel oluşturacak, içinde kopyalama işlemi için özet bir metot bulunduran abstract class’tır. Bu yapı interface veya abstract class olabilir. İhtiyaca göre hangisinin olacağına karar verilir.

**Somut prototip:** Uygulamada, kopyalanması istenen gerçek nesnelerdir. Bu nesneler, soyut prototipte var olan özet metodun extends edilmesiyle (kalıtımıyla) kopyalanırlar.

**Client Uygulama:** Somut prototip nesnelerinden birer eleman elde edecek olan sınıf, metot veya bir elemandır.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/6.png)

 ```
 namespace PrototypeDesingPattern
{
    #region
    public class kisi
    {
        public int yas;
        public DateTime dogumGunu;
        public string isim;
        public IdInfo IdInfo;

        public kisi ShallowCopy()
        {
            return (kisi)this.MemberwiseClone();
        }

        public kisi DeepCopy()
        {
            kisi clone = (kisi)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.isim = String.Copy(isim);
            return clone;
        }
    }
    #endregion
    #region
    public class IdInfo
    {
        public int IdNumber;

        public IdInfo(int idNumber)
        {
            this.IdNumber = idNumber;
        }
    }
    #endregion
    #region
    class Program
    {
        static void Main(string[] args)
        {
            kisi p1 = new kisi();
            p1.yas = 42;
            p1.dogumGunu = Convert.ToDateTime("1970-05-29");
            p1.isim = "Tony Stark";
            p1.IdInfo = new IdInfo(3000);

            //P1'in basit bir kopyasını(Shallow) yapın ve p2'ye atayın.
            kisi p2 = p1.ShallowCopy();
            // P1'in derin bir kopyasını(Deep Copy) alın ve p3'e atayın.
            kisi p3 = p1.DeepCopy();

            // P1, p2 ve p3 değerlerini görüntüleyin.
            Console.WriteLine("P1, p2, p3'ün orijinal değerleri:");
            Console.WriteLine("   p1 örnek değerleri: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 örnek değerleri:");
            DisplayValues(p2);
            Console.WriteLine("   p3 örnek değerleri:");
            DisplayValues(p3);

            // P1 özelliklerinin değerini değiştirin ve p1, p2 ve p3 değerlerini görüntüleyin.
            p1.yas = 32;
            p1.dogumGunu = Convert.ToDateTime("1900-01-01");
            p1.isim = "Frank";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nP1'e değiştikten sonra p1, p2 ve p3 değerleri:");
            Console.WriteLine("   p1 örnek değerleri: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 örnek değerleri (referans değerleri değişti):");
            DisplayValues(p2);
            Console.WriteLine("   p3 örnek değerleri (her şey aynı tutuldu):");
            DisplayValues(p3);
            Console.ReadLine();
        }
        #endregion
        #region
        public static void DisplayValues(kisi p)
        {
            Console.WriteLine("      isim: {0:s}, yas: {1:d}, dogumGunu: {2:MM/dd/yy}",
                p.isim, p.yas, p.dogumGunu);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
        #endregion
    }
}
  ```

  
 
 
 
## Structural Patterns 
**Composite:** Structural Patterns gurubunda yer alan Composite Design Pattern, Bir yapıyı oluşturan nesneler topluluğunda yapıyı oluşturan parçaları ağaç (tree) hiyeraşik yapısına göre oluşturan ve aralarındaki ilişkiler için düzen sağlayan bir tasarım desenidir. 

Composite tasarım kalıbı tekil component ve birbirinden farklı componentler grubunun hiyerarşik bir yapıda benzer şekilde hareket etmesini yani kendi içlerinde birbirlerinden farklı olan bir grup nesnenin sanki tek bir bütün nesneymiş gibi kullanılmasını bileşik kalıp sağlar.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/7.png)
 
-	**Client:** İstemci uygulama
-	**Component:** Composite ve Leaf için tanımlanacak ortak şablon abstract class ya da interface olacak.
-	**Leaf:** Yapı içerisindeki nesnelerin davranışlarını tanımlayan Leaf nesnelerini sunan yapı.
-	**Composite:** İçerisinde Composite ve Leaf nesnelerini tutan yapı.

Bu örneği daha anlamlandırmak için gerçek hayattaki en iyi örnek askeri hiyerarşik yapıdır. Bir asker düşünün, bu asker bizim tekil bir nesnemiz ve generalden emir aldığı zaman uygulamakla yükümlü aynı zaman da bu askerlerin bir araya gelerek oluşturduğu tabur da yani nesneler topluluğu da generalden emir aldığında uygulamakla yükümlü. Buna ilaveten yine asker olan yani aynı parent’dan türeyen daha üst rütbeli askerler de mesela subay, albay vs gibi rütbeler de generalden emir aldığında uygulamakla yükümlü. İşte bu gibi bir hiyerarşinin düzenlenmesinde composite tasarım deseni kullanabiliriz.
 ```
namespace CompositeDesignPattern
{
    /// 
    #region Enum sabitleri
    /// Askerlerin rütbeleri
    /// 
    enum rutbe
    {
        General,
        Albay,
        Yarbay,
        Binbasi,
        Yuzbasi,
        ustTegmen
    }

    #endregion
    /// 
    #region Component
    /// Component sınıfı
    /// 
    abstract class Asker
    {

        protected string _isim;
        protected rutbe _rutbe;

        public Asker(string isim, rutbe rutbe)
        {
            _isim = isim;
            _rutbe = rutbe;
        }

        public abstract void askerEkle(Asker asker);
        public abstract void AskerSil(Asker asker);
        public abstract void ExecuteOrder(); // Hem Leaf hemde Composite tipi için uygulanacak olan fonksiyon

    }
    #endregion

    /// 
    #region Leaf 
    /// Leaf class
    /// 
    class PrimitiveSoldier : Asker
    {

        public PrimitiveSoldier(string isim, rutbe rutbe) : base(isim, rutbe)
        {

        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void askerEkle(Asker asker)
        {
            throw new NotImplementedException();
        }

        // Bu fonksiyonun Leaf için anlamı yoktur.
        public override void AskerSil(Asker asker)
        {
            throw new NotImplementedException();
        }

        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rutbe, _isim));
        }

    }

    #endregion
    /// 
    #region composite 
    /// Composite Class
    class CompositeSoldier : Asker
    {
        // Composite tip kendi içerisinde birden fazla Component tipi içerebilir. Bu tipleri bir koleksiyon içerisinde tutabilir.
        private List<Asker> _askerler = new List<Asker>();

        public CompositeSoldier(string isim, rutbe rutbe) : base(isim, rutbe)
        {

        }

        // Composite tipin altına bir Component eklemek için kullanılır
        public override void askerEkle(Asker asker)
        {
            _askerler.Add(asker);
        }

        // Composite tipin altındaki koleksiyon içerisinden bir Component tipinin çıkartmak için kullanılır
        public override void AskerSil(Asker asker)
        {
            _askerler.Remove(asker);
        }

        // Önemli nokta. Composite tip içerisindeki bu operasyon, Composite tipe bağlı tüm Component'ler için gerçekleştirilir.
        public override void ExecuteOrder()
        {
            Console.WriteLine(String.Format("{0} {1}", _rutbe, _isim));

            foreach (Asker asker in _askerler)
            {
                asker.ExecuteOrder();
            }

        }
    }
    #endregion
    #region program
    class Program
    {

        public static void Main(string[] args)
        {
            // Root oluşturulur.   
            CompositeSoldier generalMKemal = new CompositeSoldier("M.Kemal", rutbe.General);


            // root altına Leaf tipten nesne örnekleri eklenir.
            generalMKemal.askerEkle(new PrimitiveSoldier("Cezginhan", rutbe.Albay));
            generalMKemal.askerEkle(new PrimitiveSoldier("Atilla", rutbe.Albay));


            // Composite tipler oluşturulur.
            CompositeSoldier yarbayFatih = new CompositeSoldier("Fatih", rutbe.Albay);
            CompositeSoldier yarbaySuleyman = new CompositeSoldier("Süleyman", rutbe.Yarbay);


            // Composite tipe bağlı primitive tipler oluşturulur.
            yarbaySuleyman.askerEkle(new PrimitiveSoldier("Kazım", rutbe.Yuzbasi));
            yarbayFatih.askerEkle(yarbaySuleyman);
            yarbayFatih.askerEkle(new PrimitiveSoldier("Sabiha", rutbe.Yarbay));

            // Root' un altına Composite nesne örneği eklenir.
            generalMKemal.askerEkle(yarbayFatih);


            generalMKemal.askerEkle(new PrimitiveSoldier("Tomris", rutbe.Albay));


            // root için ExecuteOrder operasyonu uygulanır. Buna göre root altındaki tüm nesneler için bu operasyon uygulanır
            generalMKemal.ExecuteOrder();

            Console.ReadLine();
        }
    }
    #endregion

}
 ```


**Adapter:** tructural Patterns gurubunda yer alan Adapter Design Pattern, günlük hayatta sıklıkla karşılaşılan bir sorunun bir uygulama geliştirirken karşımıza çıkan haline çözüm oluyor. Örneğin yurtdışına çıktığınız zaman telefonunuzu ya da tıraş makinenizi şarj etmekte bir hayli zorlanabilirsiniz. Bunun nedeni sizin şarj cihazlarınızla bulunduğunuz ortamın prizlerizlerinin uyumlu olmamasıdır. Bunun çözümü için bir dönüştürücü adaptöre ihtiyacınız vardır. İşte adapter D.P’de bu işe yarıyor. Firmanın yazdığı kod ile kodunuzun arasına girip, firmanın interface’lerini sizin beklediğiniz interface tanımlamalarına çeviriyor.
  
Kullanım amacı; 

-	İki uyumsuz interface’i beraber kullanmamızı sağlar.
-	Daha önce yazılmış olan kodları düzenlemek zorunda kalmayız. Sonuçta ilgili kodun daha önce çalıştığını kabul ediyoruz.
-	Adapte edeceğimiz class üzerinde değişiklik yapmadığımız için uygulama içerisinde kullanılmış olduğu herhangi bir yerde değişiklik yapmamız gerekmez.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/8.png)

   ```
   namespace AdapterDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var yoneticiSinif = new YoneticiSinif(new NetLoggerAdapter(), "NetLogger");
            yoneticiSinif.Kaydet();

            //var yoneticiSinif = new YoneticiSinif(new XLogger(), "XLogger");
            //yoneticiSinif.Kaydet();
            Console.ReadLine();
        }
    }

    public class YoneticiSinif
    {
        private readonly ILogger _logger;
        private readonly string _mesaj;

        public YoneticiSinif(ILogger logger, string mesaj)
        {
            _logger = logger;
            _mesaj = mesaj;
        }

        public void Kaydet()
        {
            _logger.Log(_mesaj);
        }
    }

    public interface ILogger
    {
        void Log(string mesaj);
    }

    public class XLogger : ILogger
    {
        public void Log(string mesaj)
        {
            Console.WriteLine("XLog Kaydedildi!");
        }
    }

    public class NetLogger
    {
        public void LogMessage(string mesaj)
        {
            Console.WriteLine("LognetMessage" + mesaj);
        }
    }

    public class NetLoggerAdapter : ILogger
    {
        public void Log(string mesaj)
        {
            NetLogger logNet = new NetLogger();
            logNet.LogMessage(mesaj);
        }
    }
}
```

**Decorator:** Decorator tasarım deseni; structural grubuna ait bir desendir. Decorator tasarım deseni bir nesneye dinamik olarak yeni sorumlulukların eklenmesi ve hatta var olanların çıkartılması amacıyla kullanılır. Bir açıdan bakıldığında nesneyi kendisinden türeyen alt sınıflar ile genişletmek yerine kullanılabilen alternatif bir yaklaşım olarak düşünülebilir.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/9.png)
 
```
 namespace DecoratorDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string user;

            Console.WriteLine("Do you wanna add Airbag or ABS your new car? [only airbag for 1, only ABS for 2, both for 3, none for 4]");
            user = Console.ReadLine();
            
            if (user == "1")
            {
                Car car = new Car() { Model = "Astra", Brand = "Opel", Price = 35.1m, Description = "New car added." };
                car.PrintDetail();
                //nesnemize airbag özelliği ekleniyor.
                AirbagDecarotor carWithairbag = new AirbagDecarotor(car);
                carWithairbag.PrintDetail();

            }
            else if(user == "2")
            {
                Car car = new Car() { Model = "Astra", Brand = "Opel", Price = 35.1m, Description = "New car added." };
                car.PrintDetail();
                //nesnemize abs özelliği ekleniyor.
                ABSDecorator carWithABS = new ABSDecorator(car);
                carWithABS.PrintDetail();
            }
            else if(user == "3")
            {
                Car car = new Car() { Model = "Astra", Brand = "Opel", Price = 35.1m, Description = "New car added." };
                car.PrintDetail();
                //nesnemize airbag özelliği ekleniyor.
                AirbagDecarotor carWithairbag = new AirbagDecarotor(car);
                carWithairbag.PrintDetail();
                //nesnemize abs özelliği ekleniyor
                ABSDecorator carWithABS = new ABSDecorator(car);
                carWithABS.PrintDetail();
            }
            else //nesneye hiçbir özellik eklenmiyor.
            {
                Car car = new Car() { Model = "Astra", Brand = "Opel", Price = 35.1m, Description = "New car added." };
                car.PrintDetail();
            }
            Console.ReadLine();
        }
        public interface ICarDecarotor
        {
            void PrintDetail();
            void AddPrice(decimal addedPrice);
            void AddDescription(string addedDesc);
        }

        public class Car : ICarDecarotor
        {
            public string Model { get; set; }
            public string Brand { get; set; }
            public decimal Price { get; set; }
            public string Description { get; set; }

            public Car()
            {
                Price = 10.6m;
            }

            public void PrintDetail()
            {
                Console.WriteLine(Description);
            }

            public void AddPrice(decimal addedPrice)
            {
                Price += addedPrice;
            }

            public void AddDescription(string addedDesc)
            {
                Description = "Model: " + Model + " Brand: " + Brand + " Current Price: " + Price.ToString() + " " + addedDesc;
            }
        }

        public class CarDecoratorBase : ICarDecarotor
        {
            internal ICarDecarotor Car;
            public CarDecoratorBase(ICarDecarotor car)
            {
                Car = car;
            }
            public virtual void PrintDetail()
            {
                Car.PrintDetail();
            }

            public virtual void AddPrice(decimal addedPrice)
            {
                Car.AddPrice(addedPrice);
            }

            public virtual void AddDescription(string addedDesc)
            {
                Car.AddDescription(addedDesc);
            }
        }

        public class ABSDecorator : CarDecoratorBase
        {
            public ABSDecorator(ICarDecarotor car)
                : base(car)
            {
            }

            public override void PrintDetail()
            {
                base.Car.AddPrice(6.1m);
                base.Car.AddDescription("ABS added to current car.");
                base.Car.PrintDetail();
            }
        }

        public class AirbagDecarotor : CarDecoratorBase
        {
            public AirbagDecarotor(ICarDecarotor car)
                : base(car)
            {
            }

            public override void PrintDetail()
            {
                base.Car.AddPrice(3.4m);
                base.Car.AddDescription("Airbag added to current car.");
                base.Car.PrintDetail();
            }
        }
    }
}

```
 
**Facade:** Facade deseni structural grubuna ait bir desendir. Temel anlamda class kullanımını seviyelendiren bir tasarım desenidir. Basitçe herhangi bir class/fonksiyon içinden diğer class/fonksiyon'ları çağırmaya yarayan desendir. Facade deseni sistem karmaşıklığını gizler ve client(istemci)'nin sisteme erişmesini sağlayan bir arabirim görevi üstlenir. Bu desen bir grup class'ı ve özelliklerini (fonksiyon/değişken vb.) içeren tek bir ana sınıf olarak görev yapar.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/10.png)

```
namespace FacadeDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Facade facade = new Facade();

            Customer customer1 = new Customer() { IDNo = "1245203836", Fullname = "Ahmet", CustomerNumber = 11243, CashAmount = 3456090.25M };
            Customer customer2 = new Customer() { IDNo = "2342342342", Fullname = "Mehmet", CustomerNumber = 123123, CashAmount = 34929272.36M };

            //send eft customer1 to customer2
            facade.SendEFT(customer1, customer2, 12345);

            //use credit to customer 2
            facade.UseCredit(customer2);

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int CustomerNumber { get; set; }
        public string Fullname { get; set; }
        public string IDNo { get; set; }
        public decimal CashAmount { get; set; }
    }


    public static class ControlManager
    {
        public static bool CheckHasEnoughCashInBankAccount(Customer customer, decimal amount)
        {
            if (customer.CashAmount >= amount)
                return true;
            else
                return false;
        }

        public static bool CheckCanUseCredit(string IDNo)
        {
            //test için her zaman return true
            return true;
        }
    }
    public class EFTManager
    {
        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            if (ControlManager.CheckHasEnoughCashInBankAccount(fromCustomer, eftAmount))
            {
                fromCustomer.CashAmount -= eftAmount;
                Console.WriteLine("EFT " + toCustomer.CustomerNumber + " nolu hesaba gönderildi..");
            }
            else
                Console.WriteLine("Hesabınızda yeterli miktar olmadığı için EFT işleminiz gerçekleştirilemedi.");
        }
    }

    public class CreditManager
    {
        public void UseCredit(Customer customer)
        {
            if (ControlManager.CheckCanUseCredit(customer.IDNo))
                Console.WriteLine("Kredi kullandırılmıştır.");
            else
                Console.WriteLine("Banka kredinizi onaylamamıştır.");
        }
    }

    public class Facade
    {
        private EFTManager _eftManager;
        private CreditManager _creditManager;

        public Facade()
        {
            _eftManager = new EFTManager();
            _creditManager = new CreditManager();
        }

        public void SendEFT(Customer fromCustomer, Customer toCustomer, decimal eftAmount)
        {
            _eftManager.SendEFT(fromCustomer, toCustomer, eftAmount);
        }

        public void UseCredit(Customer customer)
        {
            _creditManager.UseCredit(customer);
        }
    }

}
``` 
 
 
 
**Bridge:** Bridge deseni structural grubuna ait bir desendir. Soyutlanan nesne ve implementasyonun birbirinden ayrılarak düzenlenmesine olanak sağlar. Nesnenin değişimi impelementasyonu, implementasyonun değişimi nesneyi etkilemez. Her ikisi bağımsız olarak geliştirilebilir ve türetilen tipleri üzerinden her türlü nesne-implementasyon kombinasyonu gerçeklenebilir.

Tek bir implementasyonun farklı nesneler tarafından da kullanılmasına olanak sağlar.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/11.png)
 
Bir örnek üzerinden konuya devam edersek. Örneğin bir oyun aldınız ve oyunu açarken size video modlarını soruyor. OpenGL, Direct3D bu seçeneklerden birini seçtikten sonra oyun artık hep bu seçimle bağlantılı olarak çalışır. Bunu factory class ile de yapabilirdik fakat bridge ile yapmamız bize runtime'da değiştirebilmemizi sağlayacaktır. Video modunu oyunda istediğiniz anda değiştirebilirsiniz öyle düşünün.

Kısacası en önemli kullanım alanları **eğer bir nesneyi run-time'da oluşturacaksak ve bu nesne diğer farklı nesneler tarafından kullanılacaksa** bu pattern'i kullanmamız akıllıca olacaktır.

Sonuç çıktısında görüleceği üzere Abstraction classına eklediğimiz VideoMode bir köprü görevi gördü. Bu VideoMode'un tek bir implementasyonu ile farklı nesneler tarafından da kullanılmasına olanak sağladık. Birden fazla RefinedAbstract kullanılabilir programda.

```
 namespace BridgeDesingPattern
{
   //Interface tanımı yapılır.
    public interface IVideoMode
    {
        string GetScreen();
    }
    // IVideoMode OpenGLMode'dan kalıtılır.
    public class OpenGLMode : IVideoMode
    {
        const string MODE_NAME = "OpenGL Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }
    
    /// ConcreteImplementor for Direct3D
    
    public class Direct3DMode : IVideoMode
    {
        const string MODE_NAME = "Direct3D Mode";
        public string GetScreen()
        {
            return string.Format("Video started with {0}", MODE_NAME);
        }
    }

    
    /// The 'Abstraction' class
    
    public class VideoAbstraction
    {
        protected IVideoMode _videoMode;
        // Property
        public IVideoMode VideoMode
        {
            set { _videoMode = value; }
        }

        public virtual void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }

    }
    // VideoAbstraction VideoRefinedAbstraction'dan kalıtıldı
    public class VideoRefinedAbstraction : VideoAbstraction
    {
        public override void ShowScreen()
        {
            Console.WriteLine(_videoMode.GetScreen());
        }

    }
    // VideoAbstraction'dan video oluşturuldu.
    class Program
    {
        static void Main(string[] args)
        {
            VideoAbstraction video = new VideoRefinedAbstraction();
            video.VideoMode = new OpenGLMode();
            video.ShowScreen();

            Console.ReadLine();
        }
    }
}

 ```
 

 
**Flyweight:** Yapısal(Structural) tasarım kalıplarından olan FlyWeight, bellek tüketimini optimize etmek amacıyla kullanılan bir desendir. Aslında detayına inildiğinde son derece zekice tasarlanmış ve pek çok noktada karşımıza çıkabilecek havuz mantığını içeren bir kalıp olduğu anlaşılabilir. Burada önemli olan nokta, bellek tüketiminin çok fazla sayıda nesnenin bir arada ele alınması sırasında ortaya çıkmasıdır. Buna göre söz konusu nesnelerin ortak olan, paylaşılabilen içerikleri ve bunların dışında kendilerine has durumları olduğu takdirde, nesne üretimlerini sürekli tekrar ettirmektense basit bir havuz içerisinden tedarik ettirmek, uygulamanın harcadığı bellek alanlarının optimize edilmesi için yeterli olacaktır. Bu açıdan bakıldığında desenin, paylaşımlı nesneleri efektif olarak kullanabilmek üzerine odaklandığını söyleyebiliriz.

Her bir FlyWeight nesnesi temel olarak iki önemli veri kümesinden oluşur. Kaynaklarda çoğunlukla intrinsic olarak geçen durum-bağımsız(State-Independent) kısım parçalardan birisir. Bu kısımda, çalışma zamanındaki tüm FlyWeight nesneleri tarafından saklanan paylaşılmış alanlar yer almaktadır. Diğer parça ise durum-bağımlı(State-Dependent) olarak bilinen ve kaynaklarda çoğunlukla extrinsic olarak belirtilen kısımdır. Bu kümedeki veriler ise istemci tarafından saklanır, hesap edilir ve FlyWeight nesne örneğine, yine FlyWeight' in bir operasyonu yardımıyla aktarılırlar.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/12.png)
 
UML şemamızda gördüğümüz üzere FlyWeightFactory nesnesi ile FlyWeight nesnesi arasında bir Aggregation söz konusudur. Bu son derece doğaldır nitekim fabrikamız, kendi içerisinde yer alan bir depolama alanı ile FlyWeight nesne örneklerini havuzlamakta ve istemcinin ihtiyacı olan FlyWeight nesne örneklerini bu havuzdan tedarik etmektedir. Bu noktada istemci (Client) ile, FlyWeight Factory ve Concrete FlyWeight nesneleri arasında tek yönlü bir Association söz konusudur. Yani, Client diğerlerinin nesne örnekleri ve içeriklerini kullanmaktadır. Concrete FlyWeight tipi, türeyenler için Intrinsic state verileri ile Extrinsic state verilerinin ele alındığı ortak operasyonu tanımlamaktadır. Interface veya abstract sınıf tipinden tasarlanabilir.
 
 ```
 namespace FlyweightDesingPattern
{
    enum SoldierType
    {
        Private,
        Sergeant
    }

    // FlyWeight Class
    abstract class Soldier
    {
        #region Intrinsic Fields

        // Bütün FlyWeight nesne örnekleri tarafından ortak olan ve paylaşılan veriler
        protected string UnitName;
        protected string Guns;
        protected string Health;

        #endregion

        #region Extrinsic Fields

        // İstemci tarafından değerlendirilip hesaplanan ve MoveTo operasyonua gönderilerek FlyWeight nesne örnekleri tarafından değerlendirilen veriler
        protected int X;
        protected int Y;

        #endregion

        public abstract void MoveTo(int x, int y);
    }

    // Concrete FlyWeight
    class Private
        : Soldier
    {
        public Private()
        {
            // Intrinsict değerler set edilir
            UnitName = "SWAT";
            Guns = "Machine Gun";
            Health = "Good";
        }
        public override void MoveTo(int x, int y)
        {
            // Extrinsic değerler set edilir ve bir işlem gerçekleştirilir
            X = x;
            Y = y;
            Console.WriteLine("Er ({0}:{1}) noktasına hareket etti", X, Y);
        }
    }

    // Concrete FlyWeight
    class Sergeant
        : Soldier
    {
        public Sergeant()
        {
            UnitName = "SWAT";
            Guns = "Sword";
            Health = "Good";
        }
        public override void MoveTo(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Çavuş ({0}:{1}) noktasına hareket etti", X, Y);
        }
    }

    // FlyWeight Factory
    class SoldierFactory
    {
        // Depolama alanı(Havuz).
        // Uygulama ortamında tekrar edecek olan FlyWeight nesne örnekleri depolama alanında basit birer Key ile ifade edilir
        private Dictionary<SoldierType, Soldier> _soldiers;

        public SoldierFactory()
        {
            _soldiers = new Dictionary<SoldierType, Soldier>();
        }

        public Soldier GetSoldier(SoldierType sType)
        {
            Soldier soldier = null;

            // Eğer depolama alanında, parametre olarak gelen Key ile eşleşen bir FlyWeight nesnesi var ise onu çek
            if (_soldiers.ContainsKey(sType))
                soldier = _soldiers[sType];
            else
            {
                // Yoksa Key tipine bakarak uygun FlyWeight nesne örneğini oluştur ve depolama alanına(havuz) ekle
                if (sType == SoldierType.Private)
                    soldier = new Private();
                else if (sType == SoldierType.Sergeant)
                    soldier = new Sergeant();
                _soldiers.Add(sType, soldier);
            }

            // Elde edilen FlyWeight nesnesini geri döndür
            return soldier;
        }
    }

    class Program
    {
        public static void Main()
        {
            // İstemci için örnek bir FlyWeight nesne örneği dizisi oluşturulur
            SoldierType[] soldiers = { SoldierType.Private, SoldierType.Private, SoldierType.Sergeant, SoldierType.Private, SoldierType.Sergeant };

            // FlyWeight Factory nesnesi örneklernir
            SoldierFactory factory = new SoldierFactory();

            // Extrinsic değerler set edilir
            int localtionX = 10;
            int locationY = 10;

            foreach (SoldierType soldier in soldiers)
            {
                localtionX += 10;
                locationY += 5;
                // O anki Soldier tipi için MoveTo operasyonu çağırılmadan önce fabrika nesnesinden tedarik edilir
                Soldier sld = factory.GetSoldier(soldier);
                // FlyWeight nesnesi üzerinden talep edilen operasyon çağrısı gerçekleştirilir
                sld.MoveTo(localtionX, locationY);
                Console.ReadLine();
            }
        }
    }
}
 ```
 

**Proxy:** Yapısal(Structural) tasarım kalıplarından olan Proxy tasarım deseni çalışma maliyeti yüksek işlemlerin olduğu yapılarda, web servisi kullanılan yapılarda, remoting uygulamalarında, operasyonun gerçekleştirilmesinden önce hazırlık yapılması veya ön işlem yapılması durumlarında kullanılır. Proxy D.P. Client tarafından erişilecek nesneye vekalet eden bir tasarım desenidir. Burada vekaletten kasıt ilgili nesneyi kontrol edecek bir Proxy nesnesinin kullanılmasıdır.

Üç farklı durumda Proxy D.P. kullanılır.

**Remote (Uzak) Proxy**
Remote(uzak) bir nesne kullanılacağı durumlarda kullanılabilir. Uzaktaki nesneye local bir temsilci sağlar ve gerekli kontrolleri yapmamıza olanak tanır.

**Virtual Proxy**
Üretimi yahut kullanımı maliyetli nesnelerin oluşturulması veya kullanılması için tercih edilir. Buna örnek olarak genelde herkesin dillendirdiği resim yükleme işlevini verebiliriz. Yüksek boyutlu bir resmin boyutundan dolayı geç yüklenmesi durumunda verilen -yükleniyor- mesajı ve ardından yükleme işlemi bittiği anda resmin gösterilmesinde kullanılabilir.

**Protection Proxy**
Yetkilendirme yahut login durumlarında kullanılabilir.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/13.png)
 
UML şemamıza baktığımızda Subject, Real Subject birde Proxy sınıflarımızın olduğunu göreceksiniz. Client burda DO metodunun yaptığı işi istemektedir. Fakat bu metod uzun süren bir iş olabilir. Örneğin bir web sayfası ve bu metod büyük boyutlu bir resmi sayfaya yüklüyor. Proxy kullanılmaz ise bu metod çalıştırıldığında bu resim yüklenene kadar sayfanın geri kalan metodları çalışmaz ve sayfamız yavaş çalışır yüklenme süresi artar. Bu nedenle proxy pattern'i kullanarak bu yükleme esnasında sayfayı durdurmak yerine bir önizleme resmini ekrana yazdırabiliriz. Yükleme tamamlandığında ise yüklenen resim bu önizlemenin yerine geçer.

**Client**
İstemcidir.

**Subject**
İstemcinin tek bir tip ile çalışmasını sağlayacak olan Interface yahut abstract class’ımızdır. Real Subject ve Proxy nesnelerimizin türediği yapıdır.

**Real Subject**
O anki işin asıl çalışmasını gerçekleştirecek olan gerçek nesnemizdir.

**Proxy**
Vekil sınıfımızdır. İçerisinde Real Subject referansını taşıyarak istemcinin isteklerine cevap verecektir. Doğal olarak istemci gerçek nesneye dolaylı yoldan Proxy üzerinden erişebilecektir.

```
namespace ProxyDesingPattern
{
    //Subject Class
    interface IBanka
    {
        bool OdemeYap(double Tutar);
    }
    //Real Subject Class
    class Banka : IBanka
    {
        public bool OdemeYap(double Tutar)
        {
            if (Tutar < 5)
                Console.WriteLine($"Ödeyeceğiniz tutar 5 TL'den az olamaz. Fark -> { 5 - Tutar }");
            else if (Tutar > 2000)
                Console.WriteLine($"Ödeyeceğiniz tutar 2000 TL'den fazla olamaz. Fark -> { Tutar - 2000 }");
            else
            {
                Console.WriteLine($"Ödeme başarıyla gerçekleştirildi. -> { Tutar }");
                return true;
            }

            return false;
        }
    }
    //Proxy Class
    class ProxyBanka : IBanka
    {
        Banka banka;
        bool Login;
        string KullaniciAdi, Sifre;
        public ProxyBanka(string KullaniciAdi, string Sifre)
        {
            this.KullaniciAdi = KullaniciAdi;
            this.Sifre = Sifre;
        }

        bool GirisYap()
        {
            if (KullaniciAdi.Equals("kemal") && Sifre.Equals("kml10"))
            {
                banka = new Banka();
                Login = true;
                Console.WriteLine("Hesaba giriş yapıldı.");
                return true;
            }
            else
                Console.WriteLine("Lütfen kullanıcı adı ve şifreinizi doğru girdiğinize emin olunuz.");

            Login = false;
            return false;
        }

        public bool OdemeYap(double Tutar)
        {
            GirisYap();

            if (!Login)
            {
                Console.WriteLine("Hesaba giriş yapılmadığından dolayı ödeme alamıyoruz.");
                return false;
            }

            banka.OdemeYap(Tutar);
            return true;
        }
    }

    class Program
    {
            static void Main(string[] args)
            {
                string KullaniciAdi = "", Sifre = "";
                double Tutar = 0;
                while (true)
                {
                    Console.WriteLine("Lütfen kullanıcı adınızı giriniz.");
                    KullaniciAdi = Console.ReadLine();

                    Console.WriteLine("Lütfen şifrenizi giriniz.");
                    Sifre = Console.ReadLine();

                    Console.WriteLine("Lütfen ödenecek miktarı giriniz.");
                    Tutar = Convert.ToInt32(Console.ReadLine());

                    IBanka banka = new ProxyBanka(KullaniciAdi, Sifre);
                    banka.OdemeYap(Tutar);

                    Console.WriteLine("************");
                }
            }
    }
}

```
 
 
 




## Behavioral patterns
**Chain of Responsibility:** Chain of Responsibility (Sorumluluk Zinciri) tasarım deseni behavior grubununa ait, bir isteğin belli sınıflar içinde gezdirilerek ilgili sınıfın işlem yapmasını yöneten tasarım desenidir. Chain of Responsibility kod karmaşasını önlemek amacıyla oluşturulmuştur. Bir işlemi yapabilecek birden fazla sınıftan hangisinin yapacağına karar veren tasarım desenidir. Projelerimizde birden fazla koşullu metotlar yazmak istediğimizde her koşul için if else 
blokları açılır ve ilgili metotlar çalıştırılmaktadır.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/14.png)

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/15.png)
 

**Handler:** Kendisinden türeyecek ConcreteHandler’ ların, işleyebilmesi için gerekli olan arayüzdür. Abstract class ya da Interface şeklinde tanımlanabilir.

**ConcreteHandler:** Gelen isteğe cevap verebilecek gerekirse isteği kendisinden sonra gelen nesneye iletir.

**Client:** Zinciri oluşturan ve zincirin ilk halkasına isteği gönderen nesnedir.

Gerçek hayattan bir örnek vermek gerekirse; veznede çalışan bir kişi için günlük nakit para çekim miktarı 40 bin TL olan bir banka düşünelim ve bu bankaya gelen bir müşteri veznede bulunan kişiden 480 bin TL para çekmek istediğini söyledi. Banka kuralları gereği bu işlemin sırasıyla veznedar, yönetici, müdür ve bölge sorumlusu tarafından sırasıyla onaylaması gerekmekte. Bakacak olduğumuzda zincir şeklinde birbirine bağlı olan bir onay yapısı bulunmakta.

Konuyla alakalı farklı bir örnek kodu vererek daha net anlaşılmasını sağlayalım. Aşağıdaki örnekte spor alanlarını **Enum** tipleri olarak tanımladık. Bu tiplere göre oluşturacağım desene spor tipleri gönderilecek ve ilgili sınıflar çalışacaktır. Uygulamada **Handler** yapısı **SporHandler** abstract sınıf olarak tanımlandı. Bu sınıfı **_SporHandler** property ile kendisine gönderen **Enum** tipinde **SporTipleri** parametresini alan **abstract** metodunu ekliyoruz. **Handler** yapısından türeyen **ConcreteHandler** sınıflarını yazıyoruz. Bu sınıflar **SporHandler** den talep edilen istekleri **Sporcu** metoduyla override edip işlemi yapıyoruz ya da **_NextHandler** ile sıradaki nesneye gönderiyoruz.
```
 namespace ChainOfResponsibilityDesingPattern
{
    
    public abstract class SporHandler
    {
        protected SporHandler _NextHandler;
        public SporHandler NextHandler { set { _NextHandler = value; } }
        public abstract void Sporcu(SporTipleri tip);
    }
    public class ConcreteHandlerFutbol : SporHandler
    {
        public override void Sporcu(SporTipleri tip)
        {
            if (tip == SporTipleri.Futbol)
            {
                Console.WriteLine("Spor Tipi : {0}", tip.ToString());
            }
            else
            {
                if (_NextHandler != null)
                {
                    _NextHandler.Sporcu(tip);
                }
            }
        }
    }
    public class ConcreteHandlerBasketbol : SporHandler
    {
        public override void Sporcu(SporTipleri tip)
        {
            if (tip == SporTipleri.Basketbol)
            {
                Console.WriteLine("Spor Tipi : {0}", tip.ToString());
            }
            else
            {
                if (_NextHandler != null)
                {
                    _NextHandler.Sporcu(tip);
                }
            }
        }
    }
    public class ConcreteHandlerTenis : SporHandler
    {
        public override void Sporcu(SporTipleri tip)
        {
            if (tip == SporTipleri.Tenis)
            {
                Console.WriteLine("Spor Tipi : {0}", tip.ToString());
            }
            else
            {
                if (_NextHandler != null)
                {
                    _NextHandler.Sporcu(tip);
                }
            }
        }
    }
    public enum SporTipleri
    {
        Futbol,
        Basketbol,
        Tenis,
    }

class Program
    {
        static void Main(string[] args)
        {
            SporHandler futbol = new ConcreteHandlerFutbol();
            SporHandler basketbol = new ConcreteHandlerBasketbol();
            SporHandler tenis = new ConcreteHandlerTenis();
            futbol.NextHandler = basketbol;
            basketbol.NextHandler = tenis;
            tenis.NextHandler = futbol;
            futbol.Sporcu(SporTipleri.Basketbol);
            futbol.Sporcu(SporTipleri.Futbol);
            futbol.Sporcu(SporTipleri.Tenis);
            Console.ReadLine();
        }
    }
}
``` 
 
**Command:** Davranışsal (Behavioral) tasarım kalıplarından biri olan komut tasarım kalıbı, nesneye dayalı programlama (Object Oriented Programing) çalışmalarında çoğu zaman farkında olmadan kullanılan bir yapıdır. Komut tasarım kalıbı, kullanıcı isteklerini gerçekleştiren kod yapısının sarmalanarak nesneler halinde saklanmasına dayanır. Öyle ki üzerinde çalışılacak nesnenin tanımının yapılamadığı durumlar olabilir. Bu şartlarda ne tür çözüm yolları ile nesneye müdahale edilmeye çalışılabileceği kestirilemez, ancak gerçekleştirilmek istenen işlemler bir nesne olarak sarmalanır. Nesne halinde tutulan bu sarmal kod yapısı, alıcı nesne için bir çözüm oluşturur. Çözümlerin nesneler halinde saklanmasının getirisi olarak da komut tasarım kalıbı aynı kod yapısının tekrar tekrar kullanılabilmesine olanak sağlar.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/16.png)
 
-	**Komut (Command):** Gerçekleştirilecek işlem için bir ara yüz tanımlar.
-	**Somut Komut (Concrete Command):** Alıcı ve gerçekleştirilecek işlemler arasında bir bağ kurar, alıcıda karşılık düşen işlemleri çağırarak çalıştırma eylemini gerçekleştirir.
-	**İstemci (Client):** Komut nesnesini oluşturur ve metodun sonraki zamanlarda çağrılabilmesi için gerekli bilgiyi sağlar.
-	**Çağırıcı (Invoker):** Metodun ne zaman çağrılacağını belirtir.
-	**Alıcı (Receiver):** Kullanıcı isteklerini gerçekleştirecek asıl metod kodlarını içerir.
Komutların nesne halinde tutulmasının getirdiği bir fayda olarak istenildiği durumlarda bu nesnelere yaptıkları işlemleri geri almak da öğretilebilir. Bunun sonucu olarak **Yinele (Redo)/Geri Al (Undo)** işlemleri gerçeklenebilir ve bir makro özelliği yaratılabilir.
```  
namespace CommandDesingPattern
{
    //1. Emri uygulayacak nesne
    public class SiparisIslemleri
    {
        public void YeniSiparisEkle() => Console.WriteLine("Yeni sipariş Eklendi");
        public void SiparisGuncelle() => Console.WriteLine("sipariş güncellendi");

    }
    //2. Çalıştırılacak her komutun standart bir arayüzü olmalı
    public interface IKomut
    {
        void Calistir();
    }
    public class SiparisEkleKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisEkleKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }

        public void Calistir()
        {
            siparisIslemleri.YeniSiparisEkle();
        }
    }
    public class SiparisGuncellemeKomutu : IKomut
    {
        private SiparisIslemleri siparisIslemleri;
        public SiparisGuncellemeKomutu(SiparisIslemleri siparisIslemleri)
        {
            this.siparisIslemleri = siparisIslemleri;
        }
        public void Calistir()
        {
            siparisIslemleri.SiparisGuncelle();
        }
    }
    // Komut nesnesini alıcı nesneye iletecek nesne 
    public class VeritabaniKomutIletici
    {
        public void Calistir(IKomut komut)
        {
            komut.Calistir();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SiparisEkleKomutu siparisEkleKomutu = new SiparisEkleKomutu(new SiparisIslemleri());
            SiparisGuncellemeKomutu siparisGuncellemeKomutu = new SiparisGuncellemeKomutu(new SiparisIslemleri());

            VeritabaniKomutIletici veritabaniIslemcisi = new VeritabaniKomutIletici();


            veritabaniIslemcisi.Calistir(siparisEkleKomutu);
            veritabaniIslemcisi.Calistir(siparisGuncellemeKomutu);

            Console.ReadLine();
        }
    }
} 
```  
**Ilerator:** Iterator (tekrarlayıcı) tasarım deseni, behavior grubununa ait, nesne koleksyonlarının (list,array,queue) elemanlarını belirlenen kurallara göre elde edilmesini düzenleyen tasarım desenidir. 

Koleksiyonlar nesne tabanlı dillerde sıkça kullandığımız yapıların başında geliyor. Iterator tasarım deseni koleksiyonunun array, queue, list olduğunun bilinmesine ihtiyaç duyumadan koleksiyon elemanları üzerinde işlem yapılabilmesini sağlar. Koleksiyon içerisindeki nesneleri örneğin foreach ile dönersek sırasıyla işleriz fakat öyle bir ihtiyacımız var ki nesneleri 3’er 3’er dönmemiz gerekiyor. Bunu iterator tasarım kalıbıyla gerçekleştirebiliriz.

Aynı zamanda kendi itaratorlerimizi yazabiliriz bu kalıpla. Örneğin bir tarih aralığı verildi bize biz bu tarih aralığındaki çalışma günlerini bulucaz. Bunu mesela for veya foreach ile yapamayız ama iterator tasarım kalıbını kullanarak günler üzerinde gezebiliriz.

**Aggregate** sınıfları koleksiyon barındıran ve bu koleksiyon ile iterator sınıfını oluşturan sınıflardı. **Iterator** sınıfları ise ileri geri gitme gibi işlemlerin yapıldığı sınıflardır.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/17.png)
 
```  
namespace IleratorDesingPattern
{
    // Item
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", ProductId.ToString(), Name, ListPrice.ToString("C2"));
        }
    }

    // Iterator
    // Nesne bütünü içerisindeki hareketlerin, yönlenmelerin gerçekleştirilebilmesi için gerekli operasyon arayüzünü tanımlar.
    interface IProductIterator
    {
        Product First();
        Product MoveNext();
        bool IsContinue { get; }
        Product Current { get; }
    }

    // Aggregate
    // Nesne bütününün, iterasyon için Concrete Iterator tipinden nesne örneği döndürecek bir metodunun olmasını söyler.
    interface IProductCollection
    {
        IProductIterator GetIterator();
    }

    // Concrete Aggregate
    // Nesne kümesini barındıran tipimiz.
    class ProductCollection
        : IProductCollection
    {
        // Product topluluğunu saklamak için generic bir List<T> koleksiyonundan yardım alıyoruz.
        private List<Product> list = new List<Product>();

        // Ürün sayısını dışarıya vermek için kullanılan bir özellik
        public int ProductCount
        {
            get { return list.Count; }
        }

        // Eleman eklemek ve okumak için kullanılan bir Indeksleyici
        public Product this[int index]
        {
            get { return list[index]; }
            set { list.Add(value); }
        }

        #region IProductCollection Members

        // Iterator nesnesini örnekler
        public IProductIterator GetIterator()
        {
            // Iterator nesnesi örneklenirken parametre olarak o andaki ProductCollection nesne örneği referans olarak gönderilir. 
            // Bu sayede ProductIterator isimli Concrete Iterator nesne örneği, çalışma zamanında hangi nesne bütününü dolaşacağını bilecektir.
            return new ProductIterator(this);
        }

        #endregion
    }

    // Concrete Iterator
    // Nesne bütününün bir ucundan diğerine hareket edilebilmesine olanak sağlayacak fonksiyonellikleri uygulayan asıl Iterator tipi
    class ProductIterator
        : IProductIterator
    {
        // Iterator nesne örneğinin, çalışma zamanında hangi nesne bütününü dolaşacağını bilmesi gerekmektedir. 
        private ProductCollection _books;
        private int _currentIndex = 0;
        // İstemci isterse adım sayısını değiştirebilir. Örneğin ikişer ikişer atlanarak gidilmesi sağlanabilir,
        public int StepSize { get; set; }

        // bu nedenle yapıcı metoda parametre olarak, ProductCollection(Concrete Aggregate) nesne örneğinin referansı gelir.
        // Bu referansın GetIterator metodu içerisindeki çağrı ile gönderildiğini hatırlayalım.
        public ProductIterator(ProductCollection productCollection)
        {
            _books = productCollection;
        }
        #region IProductIterator Members

        // İlk elemana gidilmesini sağlayan metod
        public Product First()
        {
            // Nerede olunduğunun takibi için _currentIndex değeri set edilir
            _currentIndex = 0;
            return _books[0];
        }

        // Bir sonraki elemana geçilmesini sağlayan metod
        public Product MoveNext()
        {
            // Nerede olunduğunun takibi için _currentIndex değeri set edilir. Adım sayısı kadar arttırılır.
            _currentIndex += StepSize;
            if (IsContinue) // Eğer takip eden bir eleman var ise geri döndürülür
                return _books[_currentIndex];
            else
                return null;
        }

        // Takip eden ürün olup olmadığını belirten read-only özellik
        public bool IsContinue
        {
            get { return _currentIndex < _books.ProductCount; }
        }

        // O anki elemanı döndüren read-only özellik
        public Product Current
        {
            get { return _books[_currentIndex]; }
        }

        #endregion
    }

    class Program
    {
        static void Main(string[] args)
        {
            ProductCollection products = new ProductCollection();

            products[0] = new Product { ProductId = 1, Name = "330 ml Seramik Bardak ", ListPrice = 12M };
            products[1] = new Product { ProductId = 2, Name = "1 Lt Cam Bardak ", ListPrice = 12.5M };
            products[2] = new Product { ProductId = 3, Name = "50 cl Pet Şişe ", ListPrice = 14.45M };

            // Iterator nesnesi products isimli koleksiyonu kullanmak üzere oluşturulur
            ProductIterator iterator = new ProductIterator(products);

            // Adım sayısı belirlenir
            iterator.StepSize = 1;

            // First ile ilk elemana konumlanılır.
            // Koşul olarak IsContinue değerine bakılır
            // İlerleme için MoveNext metodu kullanılır.
            for (
                Product product = iterator.First()
                    ; iterator.IsContinue
                    ; product = iterator.MoveNext()
                    )
            {
                Console.WriteLine(product.ToString());
                Console.ReadLine();
            }
        }
    }
}


```  
 
 
 
 
**Mediator:** Mediator design pattern (aracı tasarım deseni), behavior grubununa ait, çalışmaları birbirleri ile aynı arayüzden türeyen nesnelerin durumlarına bağlı olan nesnelerin davranışlarını düzenleyen tasarım desenidir.

Anlaşılması zor ve karmaşık yapılarda aracı nesne olarak kullanılır. Birçok nesne birbirleriyle iletişime geçmek yerine sadece bu aracı nesne ile bağlanırlar. Buda yapılan tüm karmaşık faaliyetleri gizler ve kullanıcıların etkileşimleri, sistemi daha rahat anlamasını sağlar.

Kısaca mediator tasarım deseni birbirleri ile ilişkili olan bu nesneler arasındaki iletişimin ana bir nesne üzerinden (mediator) yapılmasını sağlar. Böylece nesneler arasındaki bağ zayıflatılır ve geliştirme aşamasında kod karmaşasını önler ve kodun yönetilmesini kolaylaştırır.
 
 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/18.png)
 
 ``` 
 namespace MediatorDesingPattern
{
    // Mediator
    interface IAirportControl
    {
        void Register(Airline airLine);
        void SuggestWay(string fligthNumber, string way);
    }

    // Concrete Mediator
    class IstanbulControl
        : IAirportControl
    {
        // Concrete Colleague nesne örnekleri bu koleksiyonda depolanmaktadır.
        private Dictionary<string, Airline> _planes;

        public IstanbulControl()
        {
            _planes = new Dictionary<string, Airline>();
        }

        #region IAirportControl Members

        // Kontrol kulesine çevredeki uçakların kayıt olması için Register metodu kullanılır. Bu metod parametre olarak Colleague' den türeyen her hangibir Concrete Colleague nesne örnepğini alabilir.
        public void Register(Airline airLine)
        {
            if (!_planes.ContainsValue(airLine))
                _planes[airLine.FlightNumber] = airLine;

            // Hava yolu şirketine ait uçağın, kuleden yeni rota talep edebilmesi için, Concrete Colleague nesne örneğinin, Mediator referansının bildirilmesi gerekir.
            airLine.Airport = this;
        }

        // Concrete Colleague nesne örneklerinin yeni rota talep ederken kullandıkları metod. Bu metod o anki koşullar gereği sakladığı diğer uçakların konum bilgilerinden yararlanıp bir takım sonuçlara varmaktadır.
        // Bu sayede n tane kombinasyonun, her bir uçak tarafından ele alınması yerine, tüm bu kombinasyonlar daha az sayıya indirgenerek Mediator içerisinde değerlendirilebilmektedir.
        public void SuggestWay(string fligthNumber, string way)
        {
            // TODO: Diğer uçakların konumlarına bakılarak flightNumber için yeni bir rota önerilir. Gerekirse diğer uçaklarada farklı rotalar önerilebilir.

            // Sembolik olarak yeni bir rota belirleniyor. Bilgilendirme rotayı talep eden Concrete Colleague nesne örneğinin GetWay metoduna yapılan çağrı ile gerçekleştiriliyor.
            Thread.Sleep(250);
            Random rnd = new Random();
            _planes[fligthNumber].GetWay(String.Format("{0}:{1}E;{2}:{3}W", rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString(), rnd.Next(1, 100).ToString()));
        }

        #endregion
    }

    // Colleague
    abstract class Airline
    {
        public IAirportControl Airport { get; set; }
        public string FlightNumber { get; set; }
        public string From { get; set; }

        // Mediator' den yani kuleden yeni bir rota talep ederken kullanılan metod.
        public void RequestNewWay(string myWay)
        {
            // Çağrı dikkat edileceği üzere Mediator tipine ait nesne referansına doğru yapılmaktadır. Peki bu referansı nerede verdik. Bknz Register metodu. :)
            Airport.SuggestWay(FlightNumber, myWay);
        }

        // Mediator tipinin, çağırıda bulunacağı GetWay metodu. Bu metodun parametre içeriği, kuleden(Concrete Mediator) üzerinden gelmektedir.
        public virtual void GetWay(string messageFromAirport)
        {
            Console.WriteLine("{0} rotasına yönelmemiz gerekmektedir.", messageFromAirport);
        }
    }

    // Concrete Colleague
    class OzHawaii
        : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine("Oz Hawaii, Uçuş {0} : ", FlightNumber);
            base.GetWay(messageFromAirport);
        }
    }

    // Concrete Colleague
    class ZorluYol
        : Airline
    {
        public override void GetWay(string messageFromAirport)
        {
            Console.WriteLine("ZorluYol, Uçuş {0} : ", FlightNumber);
            base.GetWay(messageFromAirport);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Kule nesnesi örneklenir(Concrete Mediator)
            IstanbulControl istanbulKule = new IstanbulControl();

            // Kuleden hizmet alacak tüm uçakların kendisini kuleye bildirmesi gerekmektedir.
            // Bu nedenle uçaklar örneklendikten sonra Concrete Mediator tipine Register metedo yardımıyla kayıt olurlar.
            OzHawaii oh101 = new OzHawaii { Airport = istanbulKule, FlightNumber = "oh101", From = "Hawai" };
            istanbulKule.Register(oh101);
            OzHawaii oh132 = new OzHawaii { Airport = istanbulKule, FlightNumber = "oh132", From = "Roma" };
            istanbulKule.Register(oh132);
            ZorluYol zy99 = new ZorluYol { Airport = istanbulKule, FlightNumber = "zy99", From = "Antarktika" };
            istanbulKule.Register(zy99);

            // Uçaklar yeni rotalarını talep ederler.
            zy99.RequestNewWay("34:43E;41:41W");

            oh101.RequestNewWay("34:43E;41:41W");

            Console.ReadLine();
        }
    }
}

 ``` 
 
 
 
**Memento:** Behavioral Patterns(Davranışsal Kalıplar) kategorisinde bulunan Memento Design Pattern bir nesnenin önceki halinin veya hallerinin saklanması ve istenildiğinde tekrardan elde edilebilmesine yarayan tasarım kalıbıdır. 

Aslında buna en güzel örnek geri ve ileri için kullandığımız; CTRL-Z ve CTRL-Y komutlarıdır. Bu örnektede olduğu gibi elimizdeki mevcut nesnenin herhangi bir T anındaki durumunu kayda alarak, sonradan oluşabilecek değişiklikler üzerine tekrardan o kaydı elde etmemizi sağlayan bir desendir.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/19.png)

**Originator**
Yaratıcı, mucit, üretken olarak ifade edebileceğimiz bu nesne kopyası saklanacak olan nesneyi ifade etmektedir. Bu nesne, kendi kopyasının oluşturulmasından sorumlu olduğu gibi geri yüklenmesinden de sorumludur.

**Memento**
Kopyalanacak nesnenin hangi özelliklerinin tutulacağı, bir başka deyişle hangi değerlerinin işleneceğini belirttiğimiz nesnedir.

**CareTaker**
Bakıcı olarak nitelendirilen bu nesne, Memento referansını barındırmakta ve yapılacak tüm işlemlerin organizasyonunu sağlamaktadır.
 
 
``` 
namespace MementoDesingPattern
{
    // Originator Class
    // Yaratıcı sınıf
    class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }

        // O anki Product nesne örneğinin içeriğini yeni bir Memento nesne örneğinde toplar ve bunu dış ortama verir.
        public Memento Save()
        {
            return new Memento
            {
                ProductId = this.ProductId
                ,
                Name = this.Name
                ,
                ListPrice = this.ListPrice
            };
        }

        // Saklanan Memento nesne örneğini alarak o anki Product nesne örneğinin dahili içeriğinin doldurulmasında kullanılır.
        public void Restore(Memento memento)
        {
            this.ListPrice = memento.ListPrice;
            this.Name = memento.Name;
            this.ProductId = memento.ProductId;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1} ( {2} )", ProductId, Name, ListPrice.ToString("C2"));
        }
    }


    // Memento Class
    // Akıl defteri sınıfı
    // Product tipi içerisinden saklanmak amacıyla kullanılacak tüm özellikleri tanımlar
    class Memento
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal ListPrice { get; set; }
    }

    // Caretaker class
    // Bakıcı sınıf
    class Memory
    {
        public Memento ProductMemento { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Örnek bir Product nesnesi oluşturulur

            Product prd = new Product
            {
                ProductId = 1000,
                Name = "Starbucks Kahve Fincanı 330 mililitre",
                ListPrice = 12
            };
            Console.WriteLine(prd.ToString());

            // Caretaker nesnesi oluşturulur.            
            Memory memory = new Memory();
            // Memento nesnesi içeriği o anki Product örneğinden elde edilir.
            memory.ProductMemento = prd.Save();
            Console.WriteLine("Product nesnesi kaydedildi.Değişiklik yapılacak.");

            prd.ProductId = 9999;
            prd.Name = "STARBUCKS KAHVE KABI";
            prd.ListPrice = 24;
            Console.WriteLine("Yeni hali : \n\t{0}", prd.ToString());

            // Restore işlemi gerçekleştirilir
            prd.Restore(memory.ProductMemento);
            Console.WriteLine("Undo : \n\t{0}", prd.ToString());

            Console.ReadLine(); 
        }
    }
}
``` 
 
**Observer:** Behavioral Patterns(Davranışsal Kalıplar) kategorisinde bulunan Observer Design Pattern Tasarlanmış olan sistem içerisinde, değişimini izlemek istediğimiz bir değer için kullanılır.

Observer adı üzerinde gözlemci, izleyici, gözcü yahut gözetmen diye nitelendirilen, anlamı gibi işlev gören bir tasarım desenidir. Elimizdeki mevcut nesnenin durumunda herhangi bir değişiklik olduğunda, bu değişiklerden diğer nesneleri haberdar eden bir tasarımdan bahsediyoruz.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/20.png)
 
**Subject:** Takip edilecek olan nesnemiz.

**Observer:** Abstract gözlemci sınıfımız. Soyutlamanın sebebi ise birden fazla gözlemci tarafından takip edilebilmesini sağlamak.

**ConcreteObserver:** Gerçek takip eden nesnemiz.

Şimdi Observer Design Pattern için teorik olarak örnek olay ele alalım.

Elimizde bir Öğrenci nesnesi olsun. Bu Öğrenciyi takip eden; Anne, Baba ve Öğretmen nesneleri olsun. Okul, Öğrenci dersi astığı zaman onu takip eden Annesine, Babasına ve Öğretmenine direkt olarak bu durumu haber veriyor olsun. Bu kurgunun kodu aşağıdaki gibi olacaktır.
 
```  
 namespace ObserverDesingPattern
{
    abstract public class Observer
    {
        public abstract void Update();
    }
    public class BabaObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrencinin kaçtığından babasının haberi oldu.");
        }
    }

    public class AnneObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrencinin kaçtığından annesinin haberi oldu.");
        }
    }
    public class OgretmenObserver : Observer
    {
        public override void Update()
        {
            Console.WriteLine("Öğrencinin kaçtığından öğretmenin haberi oldu.");
        }
    }
    public class Ogrenci
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public string Memleket { get; set; }
        public int Sinif { get; set; }

        bool dersiAstiMi;
        //Bu property Observer D. P.'de değeri kontrol edilen özelliğimizdir.
        //set bloğuna dikkat edersek eğer set edilen değer true ise
        //Notify metodu tetiklenmekte ve tüm abonelere haber gönderilmektedir.
        public bool DersiAstiMi
        {
            get { return dersiAstiMi; }
            set
            {
                if (value = true)
                {
                    Notify();
                    dersiAstiMi = value;
                }
                else
                    dersiAstiMi = value;
            }
        }
        //Subject nesnesi kendisine abone olan gözlemcileri bu koleksiyonda tutacaktır.
        List<Observer> Gozlemciler;
        public Ogrenci()
        {
            this.Gozlemciler = new List<Observer>();
        }
        //Gözlemci ekle
        public void AboneEkle(Observer observer)
        {
            Gozlemciler.Add(observer);
        }
        //Gözlemci çıkar
        public void AboneCikar(Observer observer)
        {
            Gozlemciler.Remove(observer);
        }
        //Herhangi bir güncelleme olursa ilgili gözlemcilere haber verecek metodumuzdur.
        public void Notify()
        {
            Gozlemciler.ForEach(g =>
            {
                g.Update();
            });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci o = new Ogrenci();
            o.AboneEkle(new BabaObserver());
            o.AboneEkle(new AnneObserver());
            o.AboneEkle(new OgretmenObserver());

            o.Adi = "Ahmet";
            o.SoyAdi = "Efe";
            o.Memleket = "İstanbul";
            o.Sinif = 24;
            o.DersiAstiMi = true;

            Console.ReadKey(true);
        }
    }
}
```  
 
**State:** State design patterni, nesnenin iç durumundaki değişikliklere göre çalışma zamanında farklı davranışlar sergilemesini sağlayan tasarım kalıbıdır. Yani biraz daha açarsak nesne belli özelliklerindeki değişimlere göre farklı davranışlar, fonksiyonellikler sergilemesi gibi düşünebiliriz. Birçok örnek verebiliriz, atm’ye kartımızı taktığımızda başka kart almaması durumu, Televizyon kumandasından aynı tuşa basarak açıksa kapanması, kapalı ise açılması durumları vb.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/21.png)

 
**Context:** Durumu izlenecek nesne.

**State:** Nesnenin tüm durumlar için arayüzü ortak şablonu. Abstract Class veya Interface

**ConcreteState:** Contex yapısının durumu davranışları.

 
``` 
 namespace StateDesingPattern
{
    class Program
    {
        //Soyut State nesnesi
        public interface IAccountState
        {
            void WithdrawMoney();
            void PayInterest();
        }

        //Concrete State nesnesi - 1
        public class GoldAccount : IAccountState
        {
            public void PayInterest()
            {
                Console.WriteLine("Interest paid with Golden Account");
            }

            public void WithdrawMoney()
            {
                Console.WriteLine("Money is taken with Golden Account");
            }
        }

        //Concrete State nesnesi - 2
        public class NormalAccount : IAccountState
        {
            public void PayInterest()
            {
                Console.WriteLine("Interest paid with Normal Account");
            }

            public void WithdrawMoney()
            {
                Console.WriteLine("Money is taken with Normal Account");
            }
        }

        //State değişimlerini yöneten ve statelere göre davranışları değişen context nesnesi  
        public class Account
        {
            private IAccountState _accountState;

            public Account()
            {
                _accountState = new NormalAccount();
            }

            public void PayInterest()
            {
                _accountState.PayInterest();
            }

            public void WithdrawMoney()
            {
                _accountState.WithdrawMoney();
            }

            public void ChangeStatus(IAccountState newACcountState)
            {
                _accountState = newACcountState;
            }
        }
        static void Main(string[] args)
        {
            Account account = new Account();
            account.WithdrawMoney();
            account.PayInterest();

            account.ChangeStatus(new GoldAccount());

            account.WithdrawMoney();
            account.PayInterest();

            Console.ReadKey();
        }
    }
}
``` 

**Strategy:** Behavioral Patterns(Davranışsal Kalıplar) kategorisine giren Strategy Design Pattern üzerinde detaylı irdeleme gerçekleştirelim. Bir işlem için birden fazla farklı yöntemlerin uygulanabileceği durumlar mevcuttur. İşte bu tarz durumlarda hangi yöntemin uygulanacağını, hangisinin devreye sokulacağını Strategy Design Pattern ile gerçekleştirebiliyoruz. Yapılması istenilen bir işimiz var ve bu işi birden farklı yollarla yapma ihtiyacımız var. Bu gibi durumlarda var olan işi ilgili sınıfı sürekli refactor ederek if-else blokları ile yapmak yerine, yeni bir sınıf daha ekleyerek istenilen durumda ilgili işi ilgili sınıfta yapmamıza olanak sağlar. Böylece var olan sınıfımız üzerinde değişiklik yapmadan sistemimizi geliştirmiş olacağız. Burada en önemli tasarım prensiplerinden birisini olan Open-Closed prensibi söz konusudur. 

 ![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/22.png)

**Strategy:** Bir arayüz(Interface) tasarlayarak ortak olan tüm algoritmalarımızı burada toplarız.

**ConcreteStrategy:** Ilgili algoritmayı gerçekleyen gerçek sınıfımız.
 
``` 
 namespace StrategyDesingPattern
{
    class Opel
    {
        public Opel(string UretimTipi)
        {
            Console.WriteLine($"Opel {UretimTipi} üretilmiştir.");
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
    }
    class SeriUret : Strategy
    {
        public override Opel Uret()
        {
            return new Opel("seri");
        }
    }
    class OzelYapimUret : Strategy
    {
        public override Opel  Uret()
        {
            return new Opel("özel yapım");
        }
    }
    class SiparisUzerineUret : Strategy
    {
        public override Opel Uret()
        {
            return new Opel("sipariş üzerine");
        }

        
    }
    class Uretici
    {
        public Uretici(Strategy Yontem)
        {
            Yontem.Uret();
        }
    }
    abstract class Strategy
    {
        public abstract Opel Uret();
    }


    class Program
    {
        static void Main(string[] args)
        {
            OzelYapimUret oyUret = new OzelYapimUret();
            SeriUret sUret = new SeriUret();
            SiparisUzerineUret suUret = new SiparisUzerineUret();
            Uretici uret1 = new Uretici(oyUret);
            Uretici uret2 = new Uretici(sUret);
            Uretici uret3 = new Uretici(suUret);
            Console.Read();
        }
    }
}

```  
 
 
**Template Method:**  Template, kelime manasından da anlaşılacağı üzere şablon demektir. Haliyle yaptığımız faaliyetin inşasında belirli şablonsal algorimalar üzerinde çalışma gerçekleştirecek ve bu algoritmada değişkenlik gösteren noktalarda Template Method Design Pattern’i devreye sokacağız. Template Method tasarım kalıbı daha çok sıralı operasyonları içeren fonksiyonellikleri ilgilendirmektedir. Öyleki bu fonksiyonellikler içeisine dahil olan operasyonların bazıları, duruma göre farklı şekillerde uygulanmak istenebilir (Diğer fonksiyonlarda aslında standart olarak hep aynı işi yaparlar) Dolayısıyla fonksiyonelliğin sahiplendiği ve çalışma biçimleri değişkenlik gösterebilecek olan operasyonların kolayca genişletilebilmesi, sahip oldukları **kod parçalarının yeniden kullanılabilirliğinin arttırılması(Code Reusability)** noktasında bir çözüm gerekliliği ortaya çıkmaktadır. Template Method tasarım kalıbı burada çözüm olarak kullanılabilir.
 
![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/23.png)

**Abstract Class**

Template Metodu ve algoritmadaki sıralı operasyonları fiziksel olarak barındıran soyut sınıftır.

**Concrete Class**

Operasyonlardan override edilecek olanların uygulandığı sınıflardır.
 
``` 
 namespace TemplateDesingPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            GameReporter reporter = null;

            reporter = new XmlReporter();
            reporter.WriteSummary();
            Console.WriteLine();

            reporter = new TextReporter();
            reporter.WriteSummary();
            Console.WriteLine();

            reporter = new ConsoleReporter();
            reporter.WriteSummary();
        }
    }

    abstract class GameReporter
    {
        public void GetResults()
        {
            Console.WriteLine("Oyuncuların istatistikleri toplanıyor");
        }

        public void ParseResults()
        {
            Console.WriteLine("İstatistikler ayrıştırılıyor");
        }

        public abstract void WriteResults();

        public void WriteSummary()
        {
            GetResults();
            ParseResults();
            WriteResults();
        }
    }

    class XmlReporter
        : GameReporter
    {
        public override void WriteResults()
        {
            Console.WriteLine("İstatistikler XML dosyasına yazılıyor.");
        }
    }

    class TextReporter
        : GameReporter
    {
        public override void WriteResults()
        {
            Console.WriteLine("İstatistikler TEXT dosyasına yazdırılıyor.");
        }
    }

    class ConsoleReporter
        : GameReporter
    {
        public override void WriteResults()
        {
            Console.WriteLine("İstatistikler CONSOLE ekranına basılıyor.");
            Console.ReadLine();
        }
    }
}
``` 
**Visitor:** Behavioral Patterns gurubu içerisinde yer alan Visitor tasarım şablonu, bir sınıf hiyerarşisinde yeralan sınıflar üzerinde değişiklik yapmadan, bu sınıflara yeni metodların eklenmesini kolaylaştırır.İstenilen metod bir visitor sınıfında

implemente edilir. Bileşik bir yapı üzerine yeni işlemler eklenmesine olanak sağlar. Ziyaretçi nesne bileşik yapı içindeki nesneleri tek tek ziyaret ederek gerekli bilgileri toplayıp işleyerek kullanıcıya sunar.

![etiket](https://github.com/ankabeta/design-patterns-for-peopleops/blob/main/Images/24.png)
 
Örneğimizi de şu şekilde tasarlayalım: Mesela bir tablet sınıfımız var ve bu sınıftan türeyen bazı tabletlerin wifi özelliği var bazılarının yok aynı şekilde bir kısmının 4.5G özelliği var bir kısmının yok. Böyle olunca tabletlerin türetildiği tablet abstract sınıfına WifiAc(), 4.5GAc() gibi metot tanımlamamız çok saçma olur. Çünkü Wifi özelliği olmayan bir tablette bu metodu kullanabilir olur böyle olunca. Diğer bir yöntemde wifisi olan sınıfları bulup tek tek wifi açma metodunu eklemek ama buda kodu çok anlaşılmaz hale getirecektir. Aynı zamanda sınıfımıza başka bir özellik eklemek istediğimizde yine sınıfımıza müdahale etmek zorunda kalırız. Bu durumu ortadan kaldırmak için istenilen işleri yapan visitor sınıfları yazıp Accept metodu ile bu sınıfların içerisindeki metodları istediğimiz sınıflar için çalıştırabiliriz.
 
 
``` 
namespace VisitorDesingPattern
{
    class Program
    {

        /// The 'Tablet' abstract class
      
        public abstract class Tablet
        {
            public string Model { get; set; }
            public string Brand { get; set; }

            public Tablet(string model, string brand)
            {
                Model = model;
                Brand = brand;
            }

            public abstract void Accept(IVisitor visitor);
        }


        /// The 'ConcreteElement' class

        public class IPad : Tablet
        {
            public IPad(string model, string brand)
                : base(model, brand)
            {
            }

            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }


        /// The 'ConcreteElement' class

        public class GalaxyTab : Tablet
        {
            public GalaxyTab(string model, string brand)
                : base(model, brand)
            {
            }

            public override void Accept(IVisitor visitor)
            {
                visitor.Visit(this);
            }
        }


        /// The 'Visitor' interface

        public interface IVisitor
        {
            void Visit(Tablet tablet);
        }


        /// A 'ConcreteVisitor' class

        public class WifiVisitor : IVisitor
        {
            public void Visit(Tablet tablet)
            {
                if (tablet is IPad)
                    Console.WriteLine("Ipad wifi has open.");
                else if (tablet is GalaxyTab)
                    Console.WriteLine("GalaxyTab does not have wifi option.");
                else
                    Console.WriteLine("This object is not a tablet.");
            }
        }


        /// A 'ConcreteVisitor' class

        public class ThreeGVisitor : IVisitor
        {
            public void Visit(Tablet tablet)
            {
                if (tablet is IPad)
                    Console.WriteLine("Ipad wifi does not have 4.5G option.");
                else if (tablet is GalaxyTab)
                    Console.WriteLine("GalaxyTab 4.5G has open.");
                else
                    Console.WriteLine("This object is not a tablet.");
            }
        }

        static void Main(string[] args)
        {
            IPad iPad = new IPad("Ipad mini", "Apple");
            GalaxyTab galaxyTab = new GalaxyTab("Galaxy Tab", "Samsung");

            iPad.Accept(new WifiVisitor());
            galaxyTab.Accept(new WifiVisitor());

            iPad.Accept(new ThreeGVisitor());
            galaxyTab.Accept(new ThreeGVisitor());

            //bunun gibi baska visitor sınıfları yazarak sınıfımızı değiştirmeden
            //yeni metotlar çalıştırabilir hale getirebiliriz. 

            Console.ReadLine();

        }
    }
}
```  
 
 


