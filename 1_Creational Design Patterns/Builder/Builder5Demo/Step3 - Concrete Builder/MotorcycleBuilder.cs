using Builder5Demo.Step1_Production;
using Builder5Demo.Step2___Builder_Interface;

namespace Builder5Demo.Step3___Concrete_Builder;

public class MotorcycleBuilder : IVehicleBuilder
{
    private readonly Vehicle _vehicle = new();

    public void SetType() => _vehicle.Type = "Motorcycle";
    public void SetWheels() => _vehicle.Wheels = 2;
    public void SetEngine() => _vehicle.Engine = "V2";
    public void SetColor() => _vehicle.Color = "Black";

    public Vehicle Build() => _vehicle;
}