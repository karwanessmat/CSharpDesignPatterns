using Decorator2Demo._1.Component;
using Decorator2Demo._3.Decorate;

namespace Decorator2Demo._4.ConcreteDecorate
{

    /// <summary>   
    /// Concrete Decorator   
    /// </summary>  
   public class BasicAccessories(ICar car) : CarAccessoriesDecorator(car)
   {
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
