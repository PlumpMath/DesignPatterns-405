namespace AbstractFactory.Engines
{
    class BigEngine : IEngine
    {
        public string GetEngineType()
        {
            return "Engine capacity is 2.0L.";
        }
    }
}
