using Builder5Demo.Step1_Production;
using Builder5Demo.Step2___Builder_Interface;

namespace Builder5Demo.Step3___Concrete_Builder;

public class CarBuilder : IVehicleBuilder
{
    private readonly Vehicle _vehicle = new();

    public void SetType() => _vehicle.Type = "Car";
    public void SetWheels() => _vehicle.Wheels = 4;
    public void SetEngine() => _vehicle.Engine = "V6";
    public void SetColor() => _vehicle.Color = "Red";

    public Vehicle Build() => _vehicle;
}