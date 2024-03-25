using System;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.Refined_Abstraction
{
    internal class RedColor:IColor
    {
        public void Color()
        {
            Console.Write("Red ");
        }
    }
}
