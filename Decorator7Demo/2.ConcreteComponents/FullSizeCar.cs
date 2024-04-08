using Decorator7Demo._1.Component;

namespace Decorator7Demo._2.ConcreteComponents;

public class FullSizeCar:Car
{
    public FullSizeCar()
    {
        Description = "Full Size Car";
    }

    public override string GetDescription() => Description;

    public override double GetCarPrice() => 20000.00;
}