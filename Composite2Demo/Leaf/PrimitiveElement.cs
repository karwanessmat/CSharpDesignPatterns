using System;
using Composite2Demo.Component;

namespace Composite2Demo.Leaf
{
    /// <summary>
    /// Leaf
    /// </summary>
    class PrimitiveElement:DrawingElement
    {
        public PrimitiveElement(string name) : base(name)
        {
        }

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
