using System.Collections;
using Iterator1Demo.Step1_Iterator_Interface;
using Iterator1Demo.Step2_Concrete_Iterator;
using Iterator1Demo.Step3_Collection_Interface;

namespace Iterator1Demo.step4_Concrete_Collection
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
