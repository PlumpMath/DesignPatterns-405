using AbstractFactory;
using AbstractFactory.Cars;
using AbstractFactory.Engines;
using AbstractFactory.Doors;

namespace AbstractFactory
{
    public class AudiFactory : ICarAbstractFactory
    {
        public ICar GetHatchBack()
        {
            return new Audi(new SmallEngine(), new ThreeDoors());
        }

        public ICar GetSedan()
        {
            return new Audi(new MediumEngine(), new FiveDoors());
        }

        public ICar GetSUV()
        {
            return new Audi(new BigEngine(), new FiveDoors());
        }
    }
}
