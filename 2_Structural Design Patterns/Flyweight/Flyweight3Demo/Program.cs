using System;
using Flyweight3Demo._1_Flyweight_Interface;
using Flyweight3Demo._3_Flyweight_Factory;

namespace Flyweight3Demo;

class Program
{
    static void Main(string[] args)
    {
        var cf = new CharacterFactory();
        Character a = cf.GetCharacter("a");
        a.Display(100);
        a = cf.GetCharacter("a");
        a.Display(130);


        Character b = cf.GetCharacter("b");
        b.Display(150);
        b = cf.GetCharacter("b");
        b.Display(120);


        Character z = cf.GetCharacter("z");
        z.Display(85);

        Console.WriteLine();
        int numOfObjects = cf.TotalObjectsCreated;
        Console.WriteLine($"total no of objects created {numOfObjects}");

        Console.ReadLine();

    }
}