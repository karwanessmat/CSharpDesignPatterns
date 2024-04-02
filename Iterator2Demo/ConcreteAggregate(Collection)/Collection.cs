using System.Collections;
using Iterator2Demo.Aggregate_AbstractCollection_;
using Iterator2Demo.ConcreteIterator_Iterator_;

namespace Iterator2Demo.ConcreteAggregate_Collection_
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    internal class Collection : IAbstractCollection

    {
        private readonly ArrayList _items = new ArrayList();

        public Iterator CreateIterator()
        {
            return new Iterator(this);
        }

        // Gets item count

        public int Count => _items.Count;

        // Indexer

        public object this[int index]
        {
            get => _items[index];
            set => _items.Add(value);
        }
    }
}
