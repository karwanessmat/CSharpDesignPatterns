using System;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.RefinedAbstraction
{
    internal class RedColor:IColor
    {
        public void Color()
        {
            Console.Write("Red ");
        }
    }
}
