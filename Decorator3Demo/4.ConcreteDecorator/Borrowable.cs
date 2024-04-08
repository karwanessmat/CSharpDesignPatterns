using System;
using System.Collections.Generic;
using Decorator3Demo._1.Component;
using Decorator3Demo._3.Decorator;

namespace Decorator3Demo._4.ConcreteDecorator
{
    internal class Borrowable(LibraryItem libraryItem) : Decorator(libraryItem)
    {
        protected List<string> Borrowers = [];

        public void BorrowItem(string name)
        {
            Borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            Borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in Borrowers)
            {
                Console.WriteLine("borrower: "+borrower);
            }
        }
    }
}
