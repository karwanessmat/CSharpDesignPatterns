namespace Adapter9Demo;

public class PlugAdapter(EuropeanPlug plug) : IAmericanSocket
{
    public string PlugIn()
    {
        // Convert the EuropeanPlug method call into one that AmericanSocket expects
        return plug.GetElectricity() + " through adapter";
    }
}


// Client code