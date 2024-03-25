using System;
using System.Collections.Generic;
using System.Text;
using Decorate2Demo.Component;

namespace Decorate2Demo.ConcreteComponent
{

    /// <summary>
    /// Concrete Component
    /// </summary>
  public  class EconomyCar:ICar
    {
        public string GetDescription()
        {
            return "Economy Car";
        }

        public double GetCost()
        {
            return 450000.0;
        }
    }
}
