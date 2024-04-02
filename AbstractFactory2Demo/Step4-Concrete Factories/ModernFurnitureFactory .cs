using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2Demo.Step1_AbstractProducts;
using AbstractFactory2Demo.Step2_Concrete_Products;
using AbstractFactory2Demo.Step3_Abstract_Factories;

namespace AbstractFactory2Demo.Step4_Concrete_Factories
{
    // Step 4: Implement Concrete Factories for each style
    public class ModernFurnitureFactory:IFurnitureFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }

        public ICoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTableL();
        }
    }
}
