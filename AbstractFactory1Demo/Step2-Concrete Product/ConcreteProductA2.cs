using AbstractFactory1Demo.Step1_Abstract_Product;

namespace AbstractFactory1Demo.Step2_Concrete_Product;

public class ConcreteProductA2 : ProductA
{
    // Step 2: Create concrete product classes to implement the abstract products.
    public override string FunctionA()
    {
        return "ConcreteProductA2";
    }
}