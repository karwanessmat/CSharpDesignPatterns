using System;
using Bridge2Demo._2_Create_Concrete_Implementations;
using Bridge2Demo._3_Define_Abstraction;
using Bridge2Demo._4_Create_Refined_Abstraction;

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
