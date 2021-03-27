using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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