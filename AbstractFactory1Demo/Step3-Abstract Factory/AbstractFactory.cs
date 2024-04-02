using AbstractFactory1Demo.Step1_Abstract_Product;

namespace AbstractFactory1Demo.Step3_Abstract_Factory;

// Step 3: Create the AbstractFactory interface with methods for creating abstract products (Step 1).
public interface IAbstractFactory
{
    ProductA CreateProductA();
    ProductB CreateProductB();
}