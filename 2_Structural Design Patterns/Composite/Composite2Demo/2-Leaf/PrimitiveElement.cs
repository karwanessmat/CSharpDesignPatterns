using System;
using Composite2Demo._1_Component;

namespace Composite2Demo._2_Leaf
{
    /// <summary>
    /// Leaf
    /// </summary>
    public class PrimitiveElement(string name) : DrawingElement(name)
    {
        public override void Add(DrawingElement d)
        {
            Console.WriteLine("Can not add to PrimitiveElement");
        }

        public override void Remove(DrawingElement d)
        {
            Console.WriteLine("Can not remove to PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent)+" "+Name);
        }
    }
}
