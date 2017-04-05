using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    public interface ICar
    {
        string GetModel();
        IEngine GetEngine();
        IDoors GetDoors();
    }
}
