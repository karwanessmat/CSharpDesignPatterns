using AbstractFactory2Demo.Step1_AbstractProducts;
using AbstractFactory2Demo.Step2_Concrete_Products;
using AbstractFactory2Demo.Step3_Abstract_Factories;

namespace AbstractFactory2Demo.Step4_Concrete_Factories
{
    // Step 4: Implement Concrete Factories for each style.
    public class VictorianFurnitureFactory:IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
}
