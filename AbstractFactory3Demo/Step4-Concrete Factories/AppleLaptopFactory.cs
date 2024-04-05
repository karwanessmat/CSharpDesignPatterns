using AbstractFactory3Demo.Step1_Abstract_Products;
using AbstractFactory3Demo.Step2_Concrete_Products.ComputerTypes;
using AbstractFactory3Demo.Step2_Concrete_Products.ProcessorTypes;

namespace AbstractFactory3Demo.Step4_Concrete_Factories
{
    /// <summary>
    /// We just want to modify processors and computer types without brand because both are Apple brands.
    /// </summary>
    public class AppleLaptopFactory : AppleDesktopFactory
    {
        public override IProcessor Processor()
        {
            return new ProcessorI5();
        }

        public override IComputerType ComputerTypes()
        {
            return new Laptop();
        }
    }
}
