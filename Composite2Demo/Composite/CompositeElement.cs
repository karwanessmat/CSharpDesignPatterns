using System;
using System.Collections.Generic;
using Composite2Demo._1_Component;

namespace Composite2Demo.Composite
{

    /// <summary>
    /// Composite
    /// </summary>
    class CompositeElement(string name) : DrawingElement(name)
    {
        readonly List<DrawingElement> _elements=new();

        public override void Add(DrawingElement d)
        {
            _elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            _elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new string('-', indent)+"+ "+Name);
            foreach (var drawingElement in _elements)
            {
                drawingElement.Display(indent+1);
            }
        }
    }
}
