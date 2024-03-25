using System;
using Bridge3Demo.Implementor;

namespace Bridge3Demo.RefinedAbstraction
{
    internal class GreenColor:IColor
    {
        public void Color()
        {
            Console.Write("Green ");
        }
    }
}
