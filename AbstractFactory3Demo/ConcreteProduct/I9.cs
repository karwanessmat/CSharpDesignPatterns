using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
   public class I9:IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i9.ToString();
        }
    }
}
