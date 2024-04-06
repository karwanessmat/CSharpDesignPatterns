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

        /// <summary>
        /// must return new instance
        /// </summary>
        /// <returns></returns>
        public IPrototype Clone()
        {
            return new Button(X,Y,Color);
        }
    }
}
