using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step2_Concrete_Products;

public class VictorianCoffeeTable:ICoffeeTable
{
    public void Description()
    {
        Console.WriteLine("we are eating on victorian coffee table");
    }
}