using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
