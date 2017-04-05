using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    class BMWX3 : BMW
    {
        public BMWX3()
        {
            _engine = new BigEngine();
            _doors = new FiveDoors();
            _model = "X3";
        }
    }
}
