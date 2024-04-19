The text "An adapter converts an incompatible interface into a compatible one" means that in software design, an adapter is a construct (usually a class) that serves as a bridge between two incompatible interfaces, allowing them to work together.

Let's simplify this with an example in C# using the concept of power supply.

Imagine you have a `EuropeanPlug` which you want to use in the US, but the plug shape doesn't fit the `AmericanSocket`. The `AmericanSocket` represents the incompatible interface for the `EuropeanPlug`.

Here’s how you can use an Adapter pattern to make them compatible:

1. **Identify the Incompatibility**:
The `EuropeanPlug` cannot fit into the `AmericanSocket`.

```csharp
// Incompatible Plug (Adaptee)
public class EuropeanPlug
{
    public string GetElectricity()
    {
        return "Getting 220V from European Plug";
    }
}

// Incompatible Socket (Client's expectation)
public interface IAmericanSocket
{
    string PlugIn();
}
```

2. **Create the Adapter**:
We create an `Adapter` to make the `EuropeanPlug` fit into the `AmericanSocket`.

```csharp
// Adapter
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
```

3. **Use the Adapter**:
Now the `Client` can use the `EuropeanPlug` as if it was an `AmericanSocket`.

```csharp
// Client code
public class AmericanAppliance
{
    private IAmericanSocket _socket;

    public AmericanAppliance(IAmericanSocket socket)
    {
        _socket = socket;
    }

    public void PlugIn()
    {
        Console.WriteLine(_socket.PlugIn());
    }
}
```

4. **Test the Adapter**:
We can test the `Adapter` to see the result.

```csharp
public class Program
{
    public static void Main()
    {
        EuropeanPlug europeanPlug = new EuropeanPlug();
        IAmericanSocket adapter = new PlugAdapter(europeanPlug);
        AmericanAppliance appliance = new AmericanAppliance(adapter);

        appliance.PlugIn(); // This should output "Getting 220V from European Plug through adapter"
    }
}
```

If you run this program, the result would be the console printing out the message showing that the `EuropeanPlug` can now be used with the `AmericanAppliance` through the `PlugAdapter`.