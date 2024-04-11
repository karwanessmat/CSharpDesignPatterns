using Iterator1Demo.Step1_Iterator_Interface;
using Iterator1Demo.step4_Concrete_Collection;

namespace Iterator1Demo.Step2_Concrete_Iterator
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
            return HasNext() ? aggregate[_current++] : null;


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

        public override bool HasNext()
        {
            return _current < aggregate.Count;
        }

        // Gets whether iterations are complete
        public override bool IsDone()
        {
            return _current >= aggregate.Count;
        }
    }
}
