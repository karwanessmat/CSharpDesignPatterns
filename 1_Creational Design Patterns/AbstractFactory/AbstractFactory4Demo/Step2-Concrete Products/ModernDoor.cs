using AbstractFactory4Demo.Step1_Abstract_Products;

namespace AbstractFactory4Demo.Step2_Concrete_Products;

public class ModernDoor : IDoor
{
    public void Describe() => Console.WriteLine("I am a Modern style door.");
}