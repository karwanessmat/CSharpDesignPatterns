using Decorator7Demo._1_Component_Interface;

namespace Decorator7Demo._2_Create_a_Concrete_Component;

public class CompactCar : Car
{
    public CompactCar()
    {
        Description = "Compact Car";
    }

    public override string GetDescription() => Description;
    public override double GetCarPrice() => 10000.00;
}