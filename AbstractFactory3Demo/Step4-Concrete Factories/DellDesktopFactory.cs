using AbstractFactory3Demo.Step1_Abstract_Product;
using AbstractFactory3Demo.Step2_Concrete_Product.Brands;
using AbstractFactory3Demo.Step2_Concrete_Product.ComputerTypes;
using AbstractFactory3Demo.Step2_Concrete_Product.ProcessorTypes;
using AbstractFactory3Demo.Step3_Abstract_Factory;

namespace AbstractFactory3Demo.Step4_Concrete_Factories
{
    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return  new Dell();
        }

        public virtual IComputerType ComputerTypes()
        {
           return new Desktop();
        }

        public virtual IProcessor Processor()
        {
            return new ProcessorI7();
        }
    }
}
