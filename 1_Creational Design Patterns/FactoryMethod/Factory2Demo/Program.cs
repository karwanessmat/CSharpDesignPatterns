using System;
using Factory2Demo.Step1_Product_Interface;
using Factory2Demo.Step3_Creator;
using Factory2Demo.step4_Concrete_Creator;

namespace Factory2Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        CreatorVehicleFactory vf = new ConcreteVehicleFactory();


        IVehicle bike = vf.GetVehicle(VehicleType.Bike);
        bike.Drive(50);
        Console.WriteLine();

        IVehicle scooter = vf.GetVehicle(VehicleType.Scooter);
        scooter.Drive(10);

    }
}