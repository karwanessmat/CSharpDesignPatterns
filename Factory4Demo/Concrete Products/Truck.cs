using Factory4Demo.Product_Interface;

namespace Factory4Demo.Concrete_Products;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by land in a truck.");
    }
}