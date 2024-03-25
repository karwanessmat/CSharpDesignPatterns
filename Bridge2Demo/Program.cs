using System;
using Bridge2Demo.Abstraction;
using Bridge2Demo.ConcreteImplementation;
using Bridge2Demo.Refined_Abstraction;

namespace Bridge2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle1 = new Car(new Produce(), new Assemble());
            vehicle1.Manufacture();


            Vehicle vehicle2 = new Bike(new Produce(), new Assemble());
            vehicle2.Manufacture();

            Console.ReadLine();
        }
    }
}
