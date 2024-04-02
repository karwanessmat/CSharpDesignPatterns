using Factory4Demo.Step1_Product;

namespace Factory4Demo.Step2_Concretes;

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