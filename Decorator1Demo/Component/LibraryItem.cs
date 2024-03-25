using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator1Demo.Component
{
    /// <summary>
    /// The 'Component' abstract class
    /// </summary>
  public  abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get => _numCopies;
            set => _numCopies = value;
        }


        public abstract void Display();
    }
}
