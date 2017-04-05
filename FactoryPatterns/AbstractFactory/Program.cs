using AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Doors;
using AbstractFactory.Engines;
using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create factory directly - simulating user input or some program condition
            Console.WriteLine("Creating factory directly - simulating user input or some program condition.");
            Console.WriteLine();
            string carType = "bmw";
            ICarAbstractFactory carFactoryDirect = null;
            if (carType == "bmw")
                carFactoryDirect = new BMWFactory();
            else if (carType == "audi")
                carFactoryDirect = new AudiFactory();
            ICar carDirect = carFactoryDirect.GetSUV();
            IEngine engineDirect = carDirect.GetEngine();
            IDoors doorsDirect = carDirect.GetDoors();
            Console.WriteLine("SUV");
            Console.WriteLine(engineDirect.GetEngineType());
            Console.WriteLine(doorsDirect.GetDoorsType());
            Console.WriteLine(carDirect.GetModel());

            // Create factory from App Settings
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Creating factory from App Settings.");
            Console.WriteLine();
            ICarAbstractFactory carFactoryAppSet = FactoryLoader.LoadFromAppSettings();
            ICar audiAppSet = carFactoryDirect.GetHatchBack();
            IEngine engineAppSet = audiAppSet.GetEngine();
            IDoors doorsAppSet = audiAppSet.GetDoors();
            Console.WriteLine("Audi - Hatchback");
            Console.WriteLine(engineAppSet.GetEngineType());
            Console.WriteLine(doorsAppSet.GetDoorsType());

            // Creating factory from custom section in config file
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Creating factory from custom section in config file.");
            Console.WriteLine();
            ICarAbstractFactory carFactoryCustomSet = FactoryLoader.LoadFromCustomSettings();
            ICar bmwCustSet = carFactoryDirect.GetSedan();
            IEngine engineCustSet = bmwCustSet.GetEngine();
            IDoors doorsCustSet = bmwCustSet.GetDoors();
            Console.WriteLine("BMW - Sedan");
            Console.WriteLine(engineCustSet.GetEngineType());
            Console.WriteLine(doorsCustSet.GetDoorsType());
            Console.WriteLine(bmwCustSet.GetModel());

            Console.Read();
        }
    }
}
