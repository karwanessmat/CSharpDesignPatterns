using System;
using Flyweight1Demo._1_Flyweight_Interface;

namespace Flyweight1Demo._2__Concrete_Flyweight
{
    internal class ConcreteFlyweight:IFlyweight
    {
        public void StatefulOperation(object o)
        {
            Console.WriteLine(o);
        }
    }
}
