using System;
using System.Collections.Generic;
using Decorator3Demo._1_Component_Interface;
using Decorator3Demo._3__Create_an_Abstract_Decorator;

namespace Decorator3Demo._4_Create_Concrete_Decorator;

internal class Borrowable(LibraryItem libraryItem) : LibraryDecorator(libraryItem)
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