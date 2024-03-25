using System;
using System.Collections.Generic;
using System.Text;
using Decorate2Demo.Component;
using Decorate2Demo.Decorate;

namespace Decorate2Demo.ConcreteDecorate
{
    class SportAccessories:CarAccessoriesDecorator
    {
        public SportAccessories(ICar car) : base(car)
        {
        }

        public override string GetDescription()
        {
            return base.GetDescription()+", Sports Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost()+15000.0;
        }
    }
}
