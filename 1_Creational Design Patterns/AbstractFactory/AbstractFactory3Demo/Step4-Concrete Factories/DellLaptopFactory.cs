using AbstractFactory3Demo.Step1_Abstract_Products;
using AbstractFactory3Demo.Step2_Concrete_Products.ComputerTypes;
using AbstractFactory3Demo.Step2_Concrete_Products.ProcessorTypes;

namespace AbstractFactory3Demo.Step4_Concrete_Factories;

public class DellLaptopFactory : DellDesktopFactory
{
    public override IComputerType ComputerTypes()
    {
        return new Laptop();
    }

    public override IProcessor Processor()
    {
        return new ProcessorI9();
    }
}