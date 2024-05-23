using System;
using Iterator2Demo.Step2_Concrete_Iterator;
using Iterator2Demo.step4_Concrete_Collection;

namespace Iterator2Demo;

internal class Program
{
    private static void Main()
    {
        // Build a collection (ConcreteAggregate)
        var collection = new Collection
        {
            [0] = new Item("Item 0"),
            [1] = new Item("Item 1"),
            [2] = new Item("Item 2"),
            [3] = new Item("Item 3"),
            [4] = new Item("Item 4"),
            [5] = new Item("Item 5"),
            [6] = new Item("Item 6"),
            [7] = new Item("Item 7"),
            [8] = new Item("Item 8")
        };

        // Create iterator
        Iterator iterator = collection.CreateIterator();

        // Skip every other item
        iterator.Step = 2;
        Console.WriteLine("Iterating over collection:");

        for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
        {
            Console.WriteLine(item.Name);
        }

        // Wait for user

        Console.ReadKey();
    }
}