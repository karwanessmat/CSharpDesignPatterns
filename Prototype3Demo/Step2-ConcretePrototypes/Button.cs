using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prototype3Demo.Step1_Prototype_interface;

namespace Prototype3Demo.Step2_ConcretePrototypes
{
    public class Button(int x, int y, string color) : IPrototype
    {
        public int X { get; } = x;
        public int Y { get; } = y;
        public string Color { get; } = color;

        // Constructor to create a button with x, y, and color

        public string GetColor()
        {
            return Color;
        }

        public IPrototype Clone()
        {
            return new Button(X,Y,Color);
        }
    }
}
