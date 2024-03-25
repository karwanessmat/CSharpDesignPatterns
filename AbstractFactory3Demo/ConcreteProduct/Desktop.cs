using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
  public  class Desktop:IComputerTypes
    {
        public string GetComputerTypes()
        {
            return ComputerTypes.Desktop.ToString();
        }
    }
}
