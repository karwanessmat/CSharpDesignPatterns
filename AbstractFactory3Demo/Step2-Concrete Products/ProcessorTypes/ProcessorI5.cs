using AbstractFactory3Demo.Enums;
using AbstractFactory3Demo.Step1_Abstract_Products;

//Concrete_Products are specific implementations of the abstract products, representing different products to be created.
namespace AbstractFactory3Demo.Step2_Concrete_Products.ProcessorTypes
{
  public  class ProcessorI5:IProcessor
    {
        public string GetProcessor()
        {
            return Processors.i5.ToString();
        }
    }
}
