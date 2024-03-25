using System;
using Bridge2Demo.Abstraction;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.Refined_Abstraction
{
    class Bike:Vehicle
    {
        public Bike(IWorkshop workShop1, IWorkshop workShop2) : base(workShop1, workShop2)
        {
        }

        public override void Manufacture()
        {

            Console.Write("Bike ");
            WorkShop1.Work();
            WorkShop2.Work();
        }
    }
}
