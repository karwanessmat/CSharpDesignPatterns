using Decorator7Demo._1_Component_Interface;

namespace Decorator7Demo._3__Create_an_Abstract_Decorator;

public class CarDecorator(Car car):Car
{
    public override string GetDescription()
    {
        return car.GetDescription();
    }

    public override double GetCarPrice()
    {
        return car.GetCarPrice();
    }
}