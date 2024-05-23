using Iterator0Demo.Step1_Iterator_Interface;
using Iterator0Demo.Step2_Concrete_Iterator;
using Iterator0Demo.Step3_Collection_Interface;

namespace Iterator0Demo.step4_Concrete_Collection;

public class ConcreteAggregate:IAggregate
{
    private readonly List<object> _items = [];

    public int Count => _items.Count;

    public IIterator CreateIterator()
    {
        return new ConcreteIterator(this);
    }
    public object this[int index]
    {
        get => _items[index];
        set => _items.Insert(index, value);
    }

}