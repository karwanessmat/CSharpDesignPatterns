using System;
using System.Collections.Generic;
using System.Text;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.ConcreteImplementation
{
    internal class Assemble:IWorkshop

    {
        public void Work()
        {
            Console.Write("and ");
            Console.WriteLine("Assembled");
        }
    }
}
