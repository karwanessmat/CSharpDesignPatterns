using AbstractFactory2Demo.Step1_AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory2Demo.Step2_Concrete_Products
{
    public class ModernCoffeeTableL: ICoffeeTable
    {
        public void Description()
        {
            Console.WriteLine("we are eating on modern coffee table");
        }
    }
}
