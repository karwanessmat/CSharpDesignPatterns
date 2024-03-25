using System;
using System.Collections.Generic;
using System.Text;
using Decorator1Demo.Component;

namespace Decorator1Demo.Decorator
{

    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public class Decorator:LibraryItem
    {
        protected LibraryItem LibraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }

        public override void Display()
        {
           LibraryItem.Display();
        }
    }
}
