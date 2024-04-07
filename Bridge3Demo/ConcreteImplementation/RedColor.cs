using System;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.ConcreteImplementation
{
    internal class RedColor:IColor
    {
        public void Color()
        {
            Console.Write("Red ");
        }
    }
}
