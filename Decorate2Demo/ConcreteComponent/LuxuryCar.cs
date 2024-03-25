using System;
using System.Collections.Generic;
using System.Text;
using Decorate2Demo.Component;

namespace Decorate2Demo.ConcreteComponent
{
    class LuxuryCar:ICar
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }

        public double GetCost()
        {
            return 1000 - 000.0;
        }
    }
}
