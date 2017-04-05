using AbstractFactory;
using AbstractFactory.Cars;

namespace AbstractFactory
{
    public class BMWFactory : ICarAbstractFactory
    {
        public ICar GetHatchBack()
        {
            return new BMW1Series118DSE();
        }

        public ICar GetSedan()
        {
            return new BMWE90();
        }

        public ICar GetSUV()
        {
            return new BMWX3();
        }
    }
}
