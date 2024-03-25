using System;
using System.Collections.Generic;
using System.Text;

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
