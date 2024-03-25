using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.ConcreteProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteFactory
{
    public class DellDesktopFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return  new Dell();
        }

        public IComputerTypes ComputerTypes()
        {
           return new Desktop();
        }

        public virtual IProcessor Processor()
        {
            return new I7();
        }
    }
}
