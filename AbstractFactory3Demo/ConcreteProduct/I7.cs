using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
  public  class I7:IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i7.ToString();

        }
    }
}
