using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
   public class Apple:IBrand
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}
