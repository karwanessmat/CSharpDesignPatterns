using System;
using System.Collections.Generic;
using System.Text;

namespace Facade2Demo
{
    /// <summary>
    /// The 'Subsystem ClassC' class
    /// </summary>
  public  class Loan

    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
}
