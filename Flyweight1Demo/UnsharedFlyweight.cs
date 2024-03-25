using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight1Demo
{
    public class UnsharedFlyweight:IFlyweight
    {
        private object _state;
        public void StatefulOperation(object o)
        {
            _state = o;
            Console.WriteLine(o);
        }
    }
}
