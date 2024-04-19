using System;
using Template1Demo._1_AbstractClass;

namespace Template1Demo._2_ConcreteClass
{
    class ConcreteClassA: AbstractClass
    {
        public override void Operation1()
        {
            Console.WriteLine("ConcreteClassA.Operation1()");
        }

        public override void Operation2()
        {
            Console.WriteLine("ConcreteClassA.Operation2()");
        }
    }
}
