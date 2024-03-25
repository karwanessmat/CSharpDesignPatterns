using System;

namespace Factory2Demo.Concretes
{
    public class Scooter : IVehicle
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive {km} by scooter");
        }
    }
}
