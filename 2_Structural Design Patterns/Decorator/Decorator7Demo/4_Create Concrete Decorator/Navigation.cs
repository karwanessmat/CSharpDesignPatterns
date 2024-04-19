using Decorator7Demo._1_Component_Interface;
using Decorator7Demo._3__Create_an_Abstract_Decorator;

namespace Decorator7Demo._4_Create_Concrete_Decorator;

public class Navigation: CarDecorator
{
    private readonly Car _car;
    public Navigation(Car car)
        : base(car)
    {
        this._car = car;
        Description = "Navigation";
    }

    public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
    public override double GetCarPrice() => base.GetCarPrice() + 1500;
}