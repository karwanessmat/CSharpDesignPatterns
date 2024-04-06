namespace Adapter9Demo;

public class AmericanAppliance(IAmericanSocket socket)
{
    public void PlugIn()
    {
        Console.WriteLine(socket.PlugIn());
    }
}