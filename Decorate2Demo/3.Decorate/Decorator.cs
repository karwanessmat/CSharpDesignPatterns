using Decorator2Demo._1.Component;

namespace Decorator2Demo._3.Decorate
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
