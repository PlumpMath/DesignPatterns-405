using SimpleFactoryandFactoryMethod.FactoryMethod;
using SimpleFactoryandFactoryMethod.SimpleFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple Factory
            Console.WriteLine("Simple Factory");
            Console.WriteLine();
            CarFactory simpleFactory = new CarFactory();
            ICar simpleCar = simpleFactory.GetCar("bmw");
            Console.WriteLine("Setting car model in client.");
            simpleCar.SetModel("i8");
            Console.Read();

            // Factory Method
            Console.WriteLine("Factory Method");
            Console.WriteLine();
            ICarFactory factoryMethodBMW = new BMWFactory();
            factoryMethodBMW.GetCar();
            ICarFactory factoryMethodAudi = new AudiFactory();
            Console.WriteLine("Setting Audi model in client.");
            simpleCar.SetModel("TT");
            Console.Read();
        }
    }
}
