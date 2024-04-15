using System;
using Bridge2Demo.Abstraction;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.Refined_Abstraction
{
    // Refine abstraction 1 in bridge pattern 
    internal class Car(IWorkshop workShop1, IWorkshop workShop2) : Vehicle(workShop1, workShop2)
    {
        private readonly IWorkshop _workShop1 = workShop1;
        private readonly IWorkshop _workShop2 = workShop2;

        public override void Manufacture()
        {
            Console.Write("Car ");
            _workShop1.Work();
            _workShop2.Work();

        }
    } 
}
