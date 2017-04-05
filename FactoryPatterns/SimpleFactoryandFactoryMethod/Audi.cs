using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryandFactoryMethod
{
    class Audi : ICar
    {
        private string _model;

        public void SetModel(string model)
        {
            _model = model;
        }
    }
}
