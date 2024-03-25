using System;
using System.Collections.Generic;
using Decorator1Demo.Component;

namespace Decorator1Demo.ConcreteDecorator
{
    class Borrowable: Decorator.Decorator
    {
        protected List<string> borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            borrowers.Add(name);
            LibraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            borrowers.Remove(name);
            LibraryItem.NumCopies++;
        }

        public override void Display()
        {
            base.Display();

            foreach (var borrower in borrowers)
            {
                Console.WriteLine("borrower: "+borrower);
            }
        }
    }
}
