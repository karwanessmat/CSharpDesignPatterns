using Builder3Demo.Step1_Product;
using Builder3Demo.Step2_Builder_Interface;

namespace Builder3Demo.Step3_ConcreteBuilder;

public class ConcreteBuilder:IBuilder
{
    private readonly Product _product = new();
    public void BuildPartA()
    {
        _product.AddPart("A");
    }

    public void BuildPartB()
    {
        _product.AddPart("B");
    }

    public Product GetProduct()
    {
        return _product;
    }
}