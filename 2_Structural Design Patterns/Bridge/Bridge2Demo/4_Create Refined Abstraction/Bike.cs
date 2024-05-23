using System;
using Bridge2Demo._1_Define_Implementor_Interface;
using Bridge2Demo._3_Define_Abstraction;

namespace Bridge2Demo._4_Create_Refined_Abstraction;

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