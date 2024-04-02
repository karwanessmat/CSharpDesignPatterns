using AbstractFactory3Demo.Enums;
using AbstractFactory3Demo.Step1_Abstract_Product;

//Concrete_Products are specific implementations of the abstract products, representing different products to be created.
namespace AbstractFactory3Demo.Step2_Concrete_Product.ProcessorTypes
{
  public  class ProcessorI7:IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i7.ToString();

        }
    }
}
