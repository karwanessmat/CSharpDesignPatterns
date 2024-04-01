using Factory4Demo.Product_Interface;

namespace Factory4Demo.Concrete_Products;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by sea in a ship.");
    }
}