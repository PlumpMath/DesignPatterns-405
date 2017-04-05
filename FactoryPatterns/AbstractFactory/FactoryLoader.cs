using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class FactoryLoader
    {
        public static ICarAbstractFactory LoadFromAppSettings()
        {
            var factoryName = ConfigurationManager.AppSettings["CarFactory"].ToString();
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ICarAbstractFactory;
        }

        public static ICarAbstractFactory LoadFromCustomSettings()
        {
            CarFactoryConfiguration config = (CarFactoryConfiguration)ConfigurationManager.GetSection("carFactories/carFactory");
            var factoryName = config.Factory.Value;
            return Assembly.GetExecutingAssembly().CreateInstance(factoryName) as ICarAbstractFactory;
        }
    }
}
