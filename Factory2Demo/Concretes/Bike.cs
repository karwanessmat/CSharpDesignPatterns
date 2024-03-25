using System;

namespace Factory2Demo.Concretes
{
  public  class Bike:IVehicle
    {
        public void Drive(int km)
        {
            Console.WriteLine($"Drive {km} by bike");
        }
    }
}
