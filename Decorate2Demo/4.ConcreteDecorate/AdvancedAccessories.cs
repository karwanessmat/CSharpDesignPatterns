using Decorator2Demo._1.Component;
using Decorator2Demo._3.Decorate;

namespace Decorator2Demo._4.ConcreteDecorate
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
