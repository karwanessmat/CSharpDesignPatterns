using System;
using Bridge2Demo._1_Define_Implementor_Interface;

namespace Bridge2Demo._2_Create_Concrete_Implementations;

internal class Assemble:IWorkshop

{
    public void Work()
    {
        Console.Write(" and ");
        Console.WriteLine("Assembled");
    }
}