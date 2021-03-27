using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesingPattern
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
