using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    class BMWE90 : BMW
    {
        public BMWE90()
        {
            _engine = new MediumEngine();
            _doors = new FiveDoors();
            _model = "E90";
        }
    }
}
