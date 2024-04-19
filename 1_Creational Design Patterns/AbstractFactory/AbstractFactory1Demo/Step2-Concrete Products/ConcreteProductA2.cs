using AbstractFactory1Demo.Step1_Abstract_Products;

namespace AbstractFactory1Demo.Step2_Concrete_Products;

public class ConcreteProductA2 : ProductA
{
    // Step 2: Create concrete product classes to implement the abstract products.
    public override string FunctionA()
    {
        return "ConcreteProductA2";
    }
}