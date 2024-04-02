using Iterator3Demo.ConcreteAggregate_Collection_.IteratorDesignPattern;
using Iterator3Demo.Iterator_AbstractIterator_.IteratorDesignPattern;

namespace Iterator3Demo.ConcreteIterator_Iterator_
{

      public  class Iterator : IAbstractIterator
        {
            private readonly ConcreteCollection _collection;
            private int _current;
            private const int Step = 1;

            // Constructor
            public Iterator(ConcreteCollection collection)
            {
                _collection = collection;
            }

            // Gets first item
            public Employee First()
            {
                _current = 0;
                return _collection.GetEmployee(_current);
            }

            // Gets next item
            public Employee Next()
            {
                _current += Step;
                return !IsCompleted ? _collection.GetEmployee(_current) : null;
            }

            // Check whether iteration is complete
            public bool IsCompleted => _current >= _collection.Count;
        }
    
}
