using System;
using Bridge2Demo.Abstraction;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.Refined_Abstraction
{
    // Refine abstraction 1 in bridge pattern 
    internal class Car:Vehicle
    {
        public Car(IWorkshop workShop1, IWorkshop workShop2) : base(workShop1, workShop2)
        {
        }

        public override void Manufacture()
        {
            Console.Write("Car ");
            WorkShop1.Work();
            WorkShop2.Work();

        }
    } 
}
