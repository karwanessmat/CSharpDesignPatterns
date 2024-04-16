using Decorator2Demo._1_Component_Interface;

namespace Decorator2Demo._3__Create_an_Abstract_Decorator
{

    /// <summary>
    /// Abstract Decorator   
    /// </summary>
    public abstract class CarAccessoriesDecorator(ICar car) : ICar
    {
        public virtual string GetDescription()
        {
            return car.GetDescription();
        }

        public virtual double GetCost()
        {
            return car.GetCost();
        }
    }
}
