using System;
using Builder1Demo.Step3_ConcreteBuilder;
using Builder1Demo.Step4_Director;

namespace Builder1Demo
{
    class Program
    {
        private static void Main(string[] args)
        {
           var toyACreator = new ToyCreator(new ToyABuilder());
           toyACreator.CreateToy();
           Console.WriteLine(toyACreator.GetToy().ToString());
           Console.WriteLine();
           var toyBCreator = new ToyCreator(new ToyBBuilder());
           toyBCreator.CreateToy();
           Console.WriteLine(toyBCreator.GetToy());
        }
    }
}
