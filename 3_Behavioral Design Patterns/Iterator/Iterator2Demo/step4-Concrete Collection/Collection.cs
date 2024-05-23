using System.Collections;
using Iterator2Demo.Step2_Concrete_Iterator;
using Iterator2Demo.Step3_Collection_Interface;

namespace Iterator2Demo.step4_Concrete_Collection;

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