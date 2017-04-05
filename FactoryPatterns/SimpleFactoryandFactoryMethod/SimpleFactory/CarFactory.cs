using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod.SimpleFactory
{
    public class CarFactory
    {
        public ICar GetCar(string brand)
        {
            switch (brand)
            {
                case "bmw":
                    return new BMW();
                case "audi":
                    return new Audi();
            }
            return null;
        }
    }
}
