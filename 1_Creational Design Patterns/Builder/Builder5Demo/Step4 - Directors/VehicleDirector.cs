using Builder5Demo.Step1_Production;
using Builder5Demo.Step2___Builder_Interface;

namespace Builder5Demo.Step4___Directors;

public class VehicleDirector(IVehicleBuilder builder)
{
    public Vehicle Construct()
    {
        builder.SetType();
        builder.SetWheels();
        builder.SetEngine();
        builder.SetColor();
        return builder.Build();
    }
    /// <summary>
    /// we are using this method when we do not return Vehicle with Construct() Method
    /// </summary>
    /// <returns></returns>
    public Vehicle VehicleMaker()
    {
        return builder.Build();
    }
}
