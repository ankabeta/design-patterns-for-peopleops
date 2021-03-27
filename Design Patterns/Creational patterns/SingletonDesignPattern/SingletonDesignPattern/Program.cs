using Microsoft.Azure.Amqp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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