using Decorate2Demo.Component;
using Decorate2Demo.Decorate;

namespace Decorate2Demo.ConcreteDecorate
{
   public class AdvancedAccessories(ICar car) : CarAccessoriesDecorator(car)
   {
       public override string GetDescription()
        {
            return base.GetDescription()+", Advanced Accessories Package";
        }

        public override double GetCost()
        {
            return base.GetCost()+10000.0;
        }
    }
}
