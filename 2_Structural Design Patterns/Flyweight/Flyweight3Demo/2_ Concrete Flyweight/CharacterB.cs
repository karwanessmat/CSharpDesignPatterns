using System;
using Flyweight3Demo._1_Flyweight_Interface;

namespace Flyweight3Demo._2__Concrete_Flyweight;

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