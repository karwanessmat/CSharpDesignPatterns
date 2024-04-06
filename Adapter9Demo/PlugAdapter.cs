namespace Adapter9Demo;

public class PlugAdapter : IAmericanSocket
{
    private EuropeanPlug _plug;

    public PlugAdapter(EuropeanPlug plug)
    {
        _plug = plug;
    }

    public string PlugIn()
    {
        // Convert the EuropeanPlug method call into one that AmericanSocket expects
        return _plug.GetElectricity() + " through adapter";
    }
}


// Client code