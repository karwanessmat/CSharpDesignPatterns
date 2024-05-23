using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step2_Concrete_Products;

public class ModernCoffeeTableL: ICoffeeTable
{
    public void Description()
    {
        Console.WriteLine("we are eating on modern coffee table");
    }
}