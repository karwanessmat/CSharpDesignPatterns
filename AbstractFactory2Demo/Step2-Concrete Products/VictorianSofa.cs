using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step2_Concrete_Products;

public class VictorianSofa : ISofa
{
    public void RelaxOn()
    {
        Console.WriteLine("Relaxing on a Victorian sofa.");
    }
}