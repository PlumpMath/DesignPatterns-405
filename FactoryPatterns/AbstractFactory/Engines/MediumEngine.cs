namespace AbstractFactory.Engines
{
    class MediumEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Engine capacity is 1.6L.";
        }
    }
}
