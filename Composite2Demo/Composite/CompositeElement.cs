using System;
using System.Collections.Generic;
using Composite2Demo.Component;

namespace Composite2Demo.Composite
{

    /// <summary>
    /// Composite
    /// </summary>
    class CompositeElement:DrawingElement
    {
        List<DrawingElement> elements=new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {
        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent)+"+ "+Name);
            foreach (var drawingElement in elements)
            {
                drawingElement.Display(indent+1);
            }
        }
    }
}
