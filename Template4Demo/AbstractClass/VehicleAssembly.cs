
namespace Template4Demo.AbstractClass;

public abstract class VehicleAssembly
{
    // The template method
    public void AssembleVehicle()
    {
        AttachFrame();
        InstallEngine();
        InstallWheels();
        AddFeatures();
    }

    protected void AttachFrame()
    {
        Console.WriteLine("Attaching the frame.");
    }

    protected abstract void InstallEngine();
    protected abstract void InstallWheels();

    protected void AddFeatures()
    {
        Console.WriteLine("Adding standard features.");
    }
}