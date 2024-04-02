using System;
using Factory2Demo.Step1_Product;

namespace Factory2Demo.Step2_Concretes
{
    public class Scooter : IVehicle
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive {km} by scooter");
        }
    }
}
