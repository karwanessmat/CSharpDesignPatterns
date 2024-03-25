using System;

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
