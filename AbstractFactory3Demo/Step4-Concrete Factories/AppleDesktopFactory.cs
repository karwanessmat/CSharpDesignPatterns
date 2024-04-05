using AbstractFactory3Demo.Step1_Abstract_Products;
using AbstractFactory3Demo.Step2_Concrete_Products.Brands;
using AbstractFactory3Demo.Step2_Concrete_Products.ComputerTypes;
using AbstractFactory3Demo.Step2_Concrete_Products.ProcessorTypes;
using AbstractFactory3Demo.Step3_Abstract_Factory;

namespace AbstractFactory3Demo.Step4_Concrete_Factories
{
  public  class AppleDesktopFactory:IComputerFactory
    {
        public IBrand Brand()
        {
            return new Apple();
        }

        public virtual IComputerType ComputerTypes()
        {
         return  new Desktop();
        }

        public virtual IProcessor Processor()
        {
            return new ProcessorI9();
        }
    }
}
