using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
