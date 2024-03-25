using System.Collections;

namespace Iterator1Demo
{
    /// <summary>
    /// The 'ConcreteAggregate' class
    /// </summary>
    internal class ConcreteAggregate : Aggregate

    {
        private readonly ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count

        public int Count => _items.Count;

        // Indexer

        public object this[int index]
        {
            get => _items[index];
            set => _items.Insert(index, value);
        }
    }

}
