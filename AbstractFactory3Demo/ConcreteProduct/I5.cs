using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
  public  class I5:IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i5.ToString();
        }
    }
}
