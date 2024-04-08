using Decorate2Demo.Component;

namespace Decorate2Demo.Decorate
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
