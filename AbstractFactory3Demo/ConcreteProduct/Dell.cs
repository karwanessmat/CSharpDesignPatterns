using AbstractFactory3Demo.AbstractProduct;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteProduct
{
    internal class Dell:IBrand
    {
        public string GetBrand()
        {
            return Brands.Dell.ToString();
        }
    }
}
