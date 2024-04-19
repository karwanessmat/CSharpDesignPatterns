using System;
using Flyweight3Demo._1_Flyweight_Interface;

namespace Flyweight3Demo._2__Concrete_Flyweight
{
    internal class CharacterA : Character
    {
        // Constructor

        public CharacterA()
        {
            Symbol = 'a';
            Height = 100;
            Width = 120;
            Ascent = 70;
            Descent = 0;
        }
        public override void Display(int pointSize)
        {
            Console.WriteLine(Symbol + " (point size " + pointSize + ")");
        }
    }
}
