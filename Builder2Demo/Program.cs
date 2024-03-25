using System;
using Builder2Demo.ConcreteBuilder;
using Builder2Demo.Director;

namespace Builder2Demo
{
    internal class Program
    {
        private static void Main()
        {

            var hondaVehicle = new VehicleCreator(new HondaBuilder());
            hondaVehicle.BuildVehicle();
            Console.WriteLine(hondaVehicle.GetVehicle());
            Console.WriteLine();


            var heroVehicle= new VehicleCreator(new HondaBuilder());
            heroVehicle.BuildVehicle();
            Console.WriteLine(heroVehicle.GetVehicle());
        }
    }
}
