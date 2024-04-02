using Factory4Demo.Step1_Product;

namespace Factory4Demo.Step2_Concretes;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by sea in a ship.");
    }
}