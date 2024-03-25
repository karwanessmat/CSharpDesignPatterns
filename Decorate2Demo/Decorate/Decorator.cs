using Decorate2Demo.Component;

namespace Decorate2Demo.Decorate
{

    /// <summary>
    /// Abstract Decorator   
    /// </summary>
    public abstract class CarAccessoriesDecorator : ICar
    {
        private readonly ICar _car;

        protected CarAccessoriesDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }
}
