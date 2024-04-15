namespace Adapter9Demo.Step3_Client___Adaptee;

// Incompatible Plug (Adaptee)
public class EuropeanPlug
{
    public string GetElectricity()
    {
        return "Getting 220V from European Plug";
    }
}

// Incompatible Socket (Client's expectation)