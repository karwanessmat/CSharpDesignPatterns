using Iterator00Demo.Step1_Iterator_Interface;
using Iterator00Demo.step4_Concrete_Collection;

namespace Iterator00Demo.Step2_Concrete_Iterator;


internal class ListIterator(ListAggregate aggregate) : IIterator
{
    private int _currentIndex = -1;

    public bool MoveNext()
    {
        if (_currentIndex + 1 >= aggregate.Count) return false;

        _currentIndex++;
        return true;

    }

    public int GetCurrent()
    {
        return aggregate[_currentIndex];
    }
}
