using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod.FactoryMethod
{
    public class AudiFactory : ICarFactory
    {
        public ICar GetCar()
        {
            return new Audi();
        }
    }
}
