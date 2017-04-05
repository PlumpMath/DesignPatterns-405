using AbstractFactory.Cars;

namespace AbstractFactory
{
    public interface ICarAbstractFactory
    {
        ICar GetHatchBack();
        ICar GetSedan();
        ICar GetSUV();
    }
}
