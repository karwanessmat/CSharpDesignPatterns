using AbstractFactory4Demo.Step1_Abstract_Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory4Demo.Step2_Concrete_Products;

// Concrete Products
public class VictorianDoor : IDoor
{
    public void Describe() => Console.WriteLine("I am a Victorian style door.");
}