using System;
using Iterator3Demo.ConcreteAggregate_Collection_.IteratorDesignPattern;

namespace Iterator3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Build a collection
            var collection = new ConcreteCollection();
            collection.AddEmployee(new Employee(@"Anurag", 100));
            collection.AddEmployee(new Employee(@"Pranaya", 101));
            collection.AddEmployee(new Employee(@"Santosh", 102));
            collection.AddEmployee(new Employee(@"Priyanka", 103));
            collection.AddEmployee(new Employee(@"Abinash", 104));
            collection.AddEmployee(new Employee(@"Preety", 105));

            // Create iterator
            var iterator = collection.CreateIterator();

            //looping iterator      
            Console.WriteLine("Iterating over collection:");

            for (Employee emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine($"ID : {emp.Id} & Name : {emp.Name}");
            }
            Console.Read();
        }
    }
}
