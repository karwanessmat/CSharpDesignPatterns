using System;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.ConcreteImplementation
{
    internal class GreenColor:IColor
    {
        public void Color()
        {
            Console.Write("Green ");
        }
    }
}
