using AbstractFactory4Demo.Step1_Abstract_Products;
using AbstractFactory4Demo.Step2_Concrete_Products;
using AbstractFactory4Demo.Step3_Abstract_Factories;

namespace AbstractFactory4Demo.Step4_Concrete_Factories;

public class ModernHouseFactory : IHouseFactory
{
    public IDoor CreateDoor() => new ModernDoor();
    public IWindow CreateWindow() => new ModernWindow();
}