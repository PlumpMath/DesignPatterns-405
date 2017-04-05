namespace AbstractFactory.Engines
{
    class SmallEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Engine capacity is 1.2L.";
        }
    }
}
