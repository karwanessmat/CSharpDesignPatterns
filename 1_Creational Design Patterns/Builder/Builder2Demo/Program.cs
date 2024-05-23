using System;
using Builder2Demo.Step3_ConcreteBuilder;
using Builder2Demo.step4_Director;

namespace Builder2Demo;

internal class Program
{
    private static void Main()
    {

        var hondaVehicle = new VehicleCreator(new HondaBuilder());
        hondaVehicle.BuildVehicle();
        Console.WriteLine(hondaVehicle.GetVehicle());

        Console.WriteLine();


        var heroVehicle= new VehicleCreator(new FordBuilder());
        heroVehicle.BuildVehicle();
        Console.WriteLine(heroVehicle.GetVehicle());
    }
}