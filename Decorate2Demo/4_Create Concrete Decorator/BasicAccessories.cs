using Decorator2Demo._1_Component_Interface;
using Decorator2Demo._3__Create_an_Abstract_Decorator;

namespace Decorator2Demo._4_Create_Concrete_Decorator
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
