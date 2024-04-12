using Memento0Demo.Step1__Create_the_Memento_class;

namespace Memento0Demo.Step3__Implement_the_Caretaker_Class;
// Caretaker class
public class Caretaker
{
    private readonly List<Memento> _mementoList = [];

    public void Add(Memento state)
    {
        _mementoList.Add(state);
    }

    public Memento Get(int index)
    {
        return _mementoList[index];
    }
}