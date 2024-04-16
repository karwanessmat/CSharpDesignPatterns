using System;
using Flyweight3Demo._1_Flyweight_Interface;

namespace Flyweight3Demo._2__Concrete_Flyweight
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
