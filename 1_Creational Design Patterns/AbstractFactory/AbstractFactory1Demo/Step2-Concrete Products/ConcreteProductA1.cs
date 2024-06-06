using AbstractFactory1Demo.Step1_Abstract_Products;

namespace AbstractFactory1Demo.Step2_Concrete_Products;

// Step 2: Create concrete product classes to implement the abstract products.
public class ConcreteProductA1:ProductA
   {
        public override string FunctionA()
        {
            return "ConcreteProductA1";
        }
    }
