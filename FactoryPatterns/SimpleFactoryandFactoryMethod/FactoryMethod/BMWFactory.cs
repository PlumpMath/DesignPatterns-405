using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod.FactoryMethod
{
    public class BMWFactory : ICarFactory
    {
        public ICar GetCar()
        {
            ICar bmw = new BMW();
            Console.WriteLine("Setting BMW model in BMWFactory.");
            bmw.SetModel("i8");
            return bmw;
        }
    }
}
