using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.ConcreteProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteFactory
{
  public  class AppleDesktopFactory:IComputerFactory
    {
        public IBrand Brand()
        {
            return new Apple();
        }

        public virtual IComputerTypes ComputerTypes()
        {
         return    new Desktop();
        }

        public virtual IProcessor Processor()
        {
            return new I9();
        }
    }
}
