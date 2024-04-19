using System;
using Bridge2Demo._1_Define_Implementor_Interface;

namespace Bridge2Demo._2_Create_Concrete_Implementations
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
