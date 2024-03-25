using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.ConcreteProduct;

namespace AbstractFactory3Demo.ConcreteFactory
{
  public  class AppleLaptopFactory : AppleDesktopFactory
    {
        public override IProcessor Processor()
        {
            return new I5();
        }

        public override IComputerTypes ComputerTypes()
        {
            return new Laptop();
        }
    }
}
