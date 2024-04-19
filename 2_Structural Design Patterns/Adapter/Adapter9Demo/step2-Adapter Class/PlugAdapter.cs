using Adapter9Demo.Step1___Interface;
using Adapter9Demo.Step3_Client___Adaptee;

namespace Adapter9Demo.step2_Adapter_Class;

public class PlugAdapter(EuropeanPlug plug) : IAmericanSocket
{
    public string PlugIn()
    {
        // Convert the EuropeanPlug method call into one that AmericanSocket expects
        return plug.GetElectricity() + " through adapter";
    }
}


// Client code