using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter7Demo
{
    // Adaptee code
    public class Adaptee
    {
        public void IncompatibleMethod()
        {
            Console.WriteLine("Adaptee - IncompatibleMethod");
        }
    }
}
