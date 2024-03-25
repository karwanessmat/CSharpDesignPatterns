using System;
using Flyweight3Demo.Flyweight_Abstract;

namespace Flyweight3Demo.ConcreteFlyweight
{
    class CharacterB:Character
    {
        public CharacterB()
        {
            Symbol = 'B';
            Height = 100;
            Width = 140;
            Ascent = 72;
            Descent = 0;
        }
        public override void Display(int pointSize)
        {
            Console.WriteLine(Symbol + " (point size " + pointSize + ")");
        }
    }
}
