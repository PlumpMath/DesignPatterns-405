using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    class BMW1Series118DSE : BMW
    {
        public BMW1Series118DSE()
        {
            _engine = new SmallEngine();
            _doors = new ThreeDoors();
            _model = "1 Series 118 D SE";
        }
    }
}
