using System;
using Flyweight1Demo._1_Flyweight_Interface;

namespace Flyweight1Demo._2__Concrete_Flyweight
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
