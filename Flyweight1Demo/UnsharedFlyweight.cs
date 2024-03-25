using System;

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
