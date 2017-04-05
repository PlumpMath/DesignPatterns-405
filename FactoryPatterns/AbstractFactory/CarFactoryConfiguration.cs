using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarFactoryConfiguration : ConfigurationSection
    {
        [ConfigurationProperty("factory")]
        public FactoryElement Factory
        {
            get
            {
                return (FactoryElement)this["factory"];
            }
            set
            { this["factory"] = value; }
        }

        public class FactoryElement : ConfigurationElement
        {
            [ConfigurationProperty("name", IsRequired = true)]
            public String Name
            {
                get
                {
                    return (String)this["name"];
                }
                set
                {
                    this["name"] = value;
                }
            }
            [ConfigurationProperty("value", IsRequired = true)]
            public String Value
            {
                get
                {
                    return (String)this["value"];
                }
                set
                {
                    this["value"] = value;
                }
            }
        }
    }
}
