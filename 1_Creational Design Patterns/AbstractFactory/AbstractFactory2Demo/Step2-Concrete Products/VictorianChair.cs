using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step2_Concrete_Products;

public class VictorianChair : IChair
{
    public void SitOn()
    {
        Console.WriteLine("Sitting on a Victorian chair.");
    }
}