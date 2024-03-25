using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
    class Laptop:IComputerTypes
    {
        public string GetComputerTypes()
        {
            return ComputerTypes.Laptop.ToString();
        }
    }
}
