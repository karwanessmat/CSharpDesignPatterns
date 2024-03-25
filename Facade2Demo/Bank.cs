using System;
using System.Collections.Generic;
using System.Text;

namespace Facade2Demo
{

    /// <summary>
    /// The 'Subsystem ClassA' class
    /// </summary>
   public class Bank

    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return amount>2500;
        }
    }
}
