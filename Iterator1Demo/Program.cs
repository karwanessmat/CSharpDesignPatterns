using System;

namespace Iterator1Demo
{
    internal class Program
    {
        private static void Main()
        {
            var a = new ConcreteAggregate
            {
                [0] = "Item A",
                [1] = "Item B",
                [2] = "Item C",
                [3] = "Item D"
            };

            // Create Iterator and provide aggregate
            var i = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            var item = i.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = i.Next();
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
