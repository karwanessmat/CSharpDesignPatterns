using System;
using System.Collections.Generic;
using System.Text;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.Abstraction
{
    // abstraction in bridge pattern 
    internal abstract class Vehicle
    {
        protected IWorkshop WorkShop1;
        protected IWorkshop WorkShop2;

        protected Vehicle(IWorkshop workShop1, IWorkshop workShop2)
        {
            this.WorkShop1 = workShop1;
            this.WorkShop2 = workShop2;
        }

        public abstract void Manufacture();
    }
}
