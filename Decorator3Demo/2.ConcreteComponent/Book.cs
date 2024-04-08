using System;
using Decorator3Demo._1.Component;

namespace Decorator3Demo._2.ConcreteComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class implementing Interface or abstract
    /// </summary>
    public class Book : LibraryItem // LibraryItem is abstract
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title,int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nbook -------");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Copies {NumCopies}");
        }
    }
}
