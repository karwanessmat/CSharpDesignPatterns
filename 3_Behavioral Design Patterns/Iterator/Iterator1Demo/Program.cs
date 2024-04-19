using System;
using Iterator1Demo.step4_Concrete_Collection;

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
            var iterator  = a.CreateIterator();

            Console.WriteLine("Iterating over collection:");

            while (iterator.HasNext())
            {
                object item = iterator.Next();
                Console.WriteLine(item);
            }

            // Wait for user

            Console.ReadKey();
        }
    }
}
