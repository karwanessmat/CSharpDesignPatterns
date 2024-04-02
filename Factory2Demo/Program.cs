using System;
using Factory2Demo.Step3_Creator;
using Factory2Demo.step4_ConcreteCreator;

namespace Factory2Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CreatorVehicleFactory vf = new ConcreteVehicleFactory();


            var bike = vf.GetVehicle(VehicleType.Bike);
            bike.Drive(50);
            Console.WriteLine();

            var scooter = vf.GetVehicle(VehicleType.Scooter);
            scooter.Drive(10);

        }
    }
}
