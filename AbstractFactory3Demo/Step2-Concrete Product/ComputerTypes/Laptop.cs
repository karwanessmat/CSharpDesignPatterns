using AbstractFactory3Demo.Step1_Abstract_Product;

//Concrete_Products are specific implementations of the abstract products, representing different products to be created.
namespace AbstractFactory3Demo.Step2_Concrete_Product.ComputerTypes
{
    public class Laptop:IComputerType
    {
        public string GetComputerTypes()
        {
            return Enums.ComputerTypes.Laptop.ToString();
        }
    }
}
