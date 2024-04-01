using Factory4Demo.Product_Interface;

namespace Factory4Demo.Concrete_Products;

/// <summary>
/// This interface represents the type of objects the factory method will create.
/// In our logistics example, this is the ITransport interface,
/// which defines the common operation for all concrete products.
/// Here, we have a single method Deliver:
/// </summary>
public class Air : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by air in a Airplane.");
    }
}