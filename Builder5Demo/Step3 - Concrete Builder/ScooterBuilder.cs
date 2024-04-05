using Builder5Demo.Step1_Production;
using Builder5Demo.Step2___Builder_Interface;

namespace Builder5Demo.Step3___Concrete_Builder;

public class ScooterBuilder : IVehicleBuilder
{
    private readonly Vehicle _vehicle = new();

    public void SetType() => _vehicle.Type = "Scooter";
    public void SetWheels() => _vehicle.Wheels = 2;
    public void SetEngine() => _vehicle.Engine = "Electric";
    public void SetColor() => _vehicle.Color = "White";

    public Vehicle Build() => _vehicle;
}