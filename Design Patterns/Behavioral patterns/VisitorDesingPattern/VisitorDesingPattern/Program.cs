using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
