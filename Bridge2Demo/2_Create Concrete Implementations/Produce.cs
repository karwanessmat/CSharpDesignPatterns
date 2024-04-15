using System;
using Bridge2Demo.Implementor;

namespace Bridge2Demo.ConcreteImplementation
{
    // Concrete implementation 1 for bridge pattern 
    public class Produce:IWorkshop
    {
        public void Work()
        {
            Console.Write("Produced");
        }
    }
}
