using AbstractFactory4Demo.Step1_Abstract_Products;

namespace AbstractFactory4Demo.Step2_Concrete_Products;

public class VictorianWindow : IWindow
{
    public void Describe() => Console.WriteLine("I am a Victorian style window.");
}