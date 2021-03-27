using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
