using Builder5Demo.Step1_Production;
using Builder5Demo.Step2___Builder_Interface;

namespace Builder5Demo.Step4___Directors;

public class VehicleDirector
{
    public Vehicle Construct(IVehicleBuilder builder)
    {
        builder.SetType();
        builder.SetWheels();
        builder.SetEngine();
        builder.SetColor();
        return builder.Build();
    }
}
