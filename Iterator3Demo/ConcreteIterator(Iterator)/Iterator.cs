using Iterator3Demo.ConcreteAggregate_Collection_.IteratorDesignPattern;
using Iterator3Demo.Iterator_AbstractIterator_.IteratorDesignPattern;

namespace Iterator3Demo.ConcreteIterator_Iterator_
{

      public class Iterator(ConcreteCollection collection) : IAbstractIterator
      {
          private int _current;
            private const int Step = 1;

            // Constructor

            // Gets first item
            public Employee First()
            {
                _current = 0;
                return collection.GetEmployee(_current);
            }

            // Gets next item
            public Employee Next()
            {
                _current += Step;
                return !IsCompleted ? collection.GetEmployee(_current) : null;
            }

            // Check whether iteration is complete
            public bool IsCompleted => _current >= collection.Count;
        }
    
}
