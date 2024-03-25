using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight1Demo
{
    internal class ConcreteFlyweight:IFlyweight
    {
        public void StatefulOperation(object o)
        {
            Console.WriteLine(o);
        }
    }
}
