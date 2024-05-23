using Iterator0Demo.Step1_Iterator_Interface;
using Iterator0Demo.step4_Concrete_Collection;

namespace Iterator0Demo.Step2_Concrete_Iterator;

/// <summary>
/// Concrete Iterator
/// Name in Code: ConcreteIterator
/// Description: Provides specific traversal mechanisms for
/// a collection and maintains the traversal's state.
/// This class implements the IIterator interface and is
/// responsible for the actual mechanism of iterating
/// over the collection.
/// </summary>
public class ConcreteIterator(ConcreteAggregate aggregate):IIterator
{
    private int current = 0;
    public bool HasNext()
    {
        return current < aggregate.Count;
    }

    public object? Next()
    {
        return HasNext()
            ? aggregate[current++]
            : null;
    }
}