using AbstractFactory3Demo.Step1_Abstract_Product;

//Concrete_Products are specific implementations of the abstract products, representing different products to be created.
namespace AbstractFactory3Demo.Step2_Concrete_Product.Brands
{
   public class Apple:IBrand
    {
        public string GetBrand()
        {
            return Enums.Brands.Apple.ToString();
        }
    }
}
