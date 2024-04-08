using Decorator7Demo._1.Component;
using Decorator7Demo._3.Decorator;

namespace Decorator7Demo._4.ConcreteDecorators;

public class Sunroof : CarDecorator
{
    private readonly Car _car;
    public Sunroof(Car car)
        : base(car)
    {
        this._car = car;
        Description = "Sunroof";
    }

    public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
    public override double GetCarPrice() => base.GetCarPrice() + 5500;
}