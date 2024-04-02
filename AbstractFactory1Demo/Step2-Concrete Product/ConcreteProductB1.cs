using AbstractFactory1Demo.Step1_Abstract_Product;

namespace AbstractFactory1Demo.Step2_Concrete_Product;

// Step 2: Create concrete product classes to implement the abstract products.
public class ConcreteProductB1 : ProductB
{

    public override string FunctionB()
    {
        return "ConcreteProductB1";
    }
}