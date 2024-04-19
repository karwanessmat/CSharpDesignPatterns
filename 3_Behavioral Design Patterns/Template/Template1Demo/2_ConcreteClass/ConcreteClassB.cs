using System;
using Template1Demo._1_AbstractClass;

namespace Template1Demo._2_ConcreteClass
{
    class ConcreteClassB:AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("ConcreteClassB.Operation1()");
        }

        public override void Operation2()
        {
            Console.WriteLine("ConcreteClassB.Operation2()");
        }
    }
}
