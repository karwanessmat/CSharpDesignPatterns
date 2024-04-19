using Factory4Demo.Step1_Product_Interface;

namespace Factory4Demo.Step2_Product_Concretes;

public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by land in a truck.");
    }
}