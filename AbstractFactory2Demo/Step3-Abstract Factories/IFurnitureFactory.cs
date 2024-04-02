using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step3_Abstract_Factories
{
    // Step 3: Declare the Abstract Factory Interface.
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeeTable CreateCoffeeTable();
    }
}
