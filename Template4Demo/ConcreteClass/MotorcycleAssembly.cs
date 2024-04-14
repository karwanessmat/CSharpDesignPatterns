using Template4Demo.AbstractClass;

namespace Template4Demo.ConcreteClass;

public class MotorcycleAssembly : VehicleAssembly
{
    protected override void InstallEngine()
    {
        Console.WriteLine("Installing a motorcycle engine.");
    }

    protected override void InstallWheels()
    {
        Console.WriteLine("Installing 2 motorcycle wheels.");
    }
}