using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod.FactoryMethod
{
    public abstract class AbstractCarFactory
    {
        public ICar CreateCar()
        {
            ICar car = this.GetCar();
            //car.SetId();
            return car;
        }
        protected abstract ICar GetCar();
    }
}
