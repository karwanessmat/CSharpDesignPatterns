using AbstractFactory1Demo.Step1_Abstract_Products;
using AbstractFactory1Demo.Step2_Concrete_Products;
using AbstractFactory1Demo.Step3_Abstract_Factory;

// Step 4: Create concrete factories that implement the abstract factory interface methods .
namespace AbstractFactory1Demo.Step4_Concrete_Factories;

public class ConcreteFactory2:IAbstractFactory
{
    public ProductA CreateProductA()
    {
        return new ConcreteProductA2();
    }

    public ProductB CreateProductB()
    {
        return new ConcreteProductB2();
    }
}