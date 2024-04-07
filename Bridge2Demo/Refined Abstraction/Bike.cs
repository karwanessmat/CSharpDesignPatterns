using System;
using Bridge2Demo.Abstraction;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.Refined_Abstraction
{
    // it is implementing abstract
    public class Bike(IWorkshop workShop1, IWorkshop workShop2) : Vehicle(workShop1, workShop2)
    {
        private readonly IWorkshop _workShop2 = workShop2;
        private readonly IWorkshop _workShop1 = workShop1;

        public override void Manufacture()
        {

            Console.Write("Bike ");
            _workShop1.Work();
            _workShop2.Work();
        }
    }
}
