using Iterator2Demo.Step1_Iterator_Interface;
using Iterator2Demo.step4_Concrete_Collection;

namespace Iterator2Demo.Step2_Concrete_Iterator
{

    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class Iterator(Collection collection) : IAbstractIterator

    {
        private int _current = 0;

        // Constructor

        // Gets first item

        public Item First()
        {
            _current = 0;
            return collection[_current] as Item;
        }

        // Gets next item

        public Item Next()
        {
            _current += Step;
            if (!IsDone)
                return collection[_current] as Item;
            return null;
        }

        // Gets or sets step size

        public int Step { get; set; } = 1;

        // Gets current iterator item

        public Item CurrentItem => collection[_current] as Item;

        // Gets whether iteration is complete

        public bool IsDone => _current >= collection.Count;
    }
}
