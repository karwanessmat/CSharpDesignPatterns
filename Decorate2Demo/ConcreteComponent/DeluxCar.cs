using System;
using System.Collections.Generic;
using System.Text;
using Decorate2Demo.Component;

namespace Decorate2Demo.ConcreteComponent
{

    /// <summary>
    /// Concrete Component
    /// </summary>
    public class DeluxCar:ICar
    {
        public string GetDescription()
        {
            return "Delux Car";
        }

        public double GetCost()
        {
            return 750000.0;
        }
    }
}
