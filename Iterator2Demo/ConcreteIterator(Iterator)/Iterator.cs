using Iterator2Demo.collection;
using Iterator2Demo.ConcreteAggregate_Collection_;
using Iterator2Demo.Iterator_AbstractIterator_;

namespace Iterator2Demo.ConcreteIterator_Iterator_
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
