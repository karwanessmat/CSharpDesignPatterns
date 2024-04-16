using Decorator7Demo._1_Component_Interface;

namespace Decorator7Demo._2_Create_a_Concrete_Component;

public class FullSizeCar:Car
{
    public FullSizeCar()
    {
        Description = "Full Size Car";
    }

    public override string GetDescription() => Description;

    public override double GetCarPrice() => 20000.00;
}