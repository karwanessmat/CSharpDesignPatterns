using System;
using Flyweight3Demo.Flyweight_Abstract;

namespace Flyweight3Demo.ConcreteFlyweight
{
    // ... C, D, E, etc.
    
    /// <summary>
    /// A 'ConcreteFlyweight' class
    /// </summary>
    internal class CharacterZ : Character

    {
        // Constructor
        public CharacterZ()
        {
            Symbol = 'Z';
            Height = 100;
            Width = 100;
            Ascent = 68;
            Descent = 0;
        }
        public override void Display(int pointSize)
        {
            Console.WriteLine(Symbol + " (point size " + pointSize + ")");
        }
    }
}
