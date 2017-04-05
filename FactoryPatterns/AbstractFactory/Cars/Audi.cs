using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    class Audi : ICar
    {
        private string _model;
        private IEngine _engine;
        private IDoors _doors;

        public Audi(IEngine engine, IDoors doors)
        {
            _engine = engine;
            _doors = doors;
        }
        public string GetModel() { return _model; }
        public IEngine GetEngine() { return _engine; }
        public IDoors GetDoors() { return _doors; }
        public void SetModel(string model) { _model = model; }
    }
}
