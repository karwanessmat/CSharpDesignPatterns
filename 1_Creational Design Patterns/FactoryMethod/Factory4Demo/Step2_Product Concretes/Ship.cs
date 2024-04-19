using Factory4Demo.Step1_Product_Interface;

namespace Factory4Demo.Step2_Product_Concretes;

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by sea in a ship.");
    }
}