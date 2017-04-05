using System;
using AbstractFactory.Doors;
using AbstractFactory.Engines;

namespace AbstractFactory.Cars
{
    abstract class BMW : ICar
    {
        protected string _model;
        protected IDoors _doors;
        protected IEngine _engine;

        public string GetModel() { return _model; }
        public IEngine GetEngine() { return _engine; }
        public IDoors GetDoors() { return _doors; }
    }
}
