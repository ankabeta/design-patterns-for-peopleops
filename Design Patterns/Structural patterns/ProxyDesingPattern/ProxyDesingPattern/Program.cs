using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
