using System;
using System.Collections.Generic;
using System.Text;

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
