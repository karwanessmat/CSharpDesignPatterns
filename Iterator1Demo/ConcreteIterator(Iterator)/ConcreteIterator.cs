using Iterator1Demo.ConcreteAggregate_Collection_;
using Iterator1Demo.Iterator_AbstractIterator_;

namespace Iterator1Demo.ConcreteIterator_Iterator_
{
    /// <summary>
    /// The 'ConcreteIterator' class
    /// </summary>
    internal class ConcreteIterator(ConcreteAggregate aggregate) : Iterator

    {
        private int _current;

        // Constructor

        // Gets first iteration item
        public override object First()
        {
            return aggregate[0];
        }

        // Gets next iteration item
        public override object Next()
        {
            object ret = null;
            if (_current < aggregate.Count - 1)
            {
                ret = aggregate[++_current];
            }

            return ret;
        }

        // Gets current iteration item
        public override object CurrentItem()
        {
            return aggregate[_current];
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= aggregate.Count;
        }
    }
}
