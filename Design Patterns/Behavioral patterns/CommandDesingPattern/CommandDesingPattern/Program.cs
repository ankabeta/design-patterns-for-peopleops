using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
