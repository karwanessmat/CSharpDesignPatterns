
using Template4Demo.AbstractClass;

namespace Template4Demo.ConcreteClass;

public class CarAssembly : VehicleAssembly
{
    protected override void InstallEngine()
    {
        Console.WriteLine("Installing a gasoline engine.");
    }

    protected override void InstallWheels()
    {
        Console.WriteLine("Installing 4 car wheels.");
    }
}