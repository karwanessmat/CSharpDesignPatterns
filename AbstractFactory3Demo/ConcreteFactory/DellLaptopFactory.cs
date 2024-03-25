using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.ConcreteProduct;

namespace AbstractFactory3Demo.ConcreteFactory
{
    public class DellLaptopFactory : DellDesktopFactory
    {
        public override IProcessor Processor()
        {
            return new I9();
        }
    }
}
