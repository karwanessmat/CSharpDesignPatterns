using Decorator2Demo._1.Component;
using Decorator2Demo._3.Decorate;

namespace Decorator2Demo._4.ConcreteDecorate
{
    public class SportAccessories(ICar car) : CarAccessoriesDecorator(car)
    {
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
