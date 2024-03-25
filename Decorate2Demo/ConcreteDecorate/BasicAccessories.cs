using System;
using System.Collections.Generic;
using System.Text;
using Decorate2Demo.Component;
using Decorate2Demo.Decorate;

namespace Decorate2Demo.ConcreteDecorate
{

    /// <summary>   
    /// Concrete Decorator   
    /// </summary>  
   public class BasicAccessories:CarAccessoriesDecorator
    {
        public BasicAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription() +", Basic Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost()+2000.0;
        }
    }
}
