using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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