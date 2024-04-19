using Iterator00Demo.Step1_Iterator_Interface;
using Iterator00Demo.Step2_Concrete_Iterator;
using Iterator00Demo.Step3_Collection_Interface;

namespace Iterator00Demo.step4_Concrete_Collection;

internal class ListAggregate : IAggregate
{
    private readonly List<int> _collection = new();

    public IIterator CreateIterator()
    {
        return new ListIterator(this);
    }

    public int Count => _collection.Count;

    public int this[int index]
    {
        get => _collection[index];
        set => _collection.Insert(index, value);
    }

    public void Insert(int value)
    {
        _collection.Add(value);
    }
}
