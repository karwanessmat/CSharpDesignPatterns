using Memento4Demo.Step1__Create_the_Memento_class;
using Memento4Demo.Step2__Define_the_Originator_class;

namespace Memento4Demo.Step3__Implement_the_Caretaker_Class;

public class Caretaker(Editor editor)
{
    private readonly Stack<Memento> _mementos = new();
    private readonly Stack<Memento> _undoMementos = new();

    // Save state
    public void Save()
    {
        _mementos.Push(editor.CreateMemento());
    }

    // Undo to the last saved state
    public void Undo()
    {
        if (_mementos.Count <= 0) return;

        Memento? memento = _mementos.Pop();
        _undoMementos.Push(memento);
        editor.RestoreState(memento);
    }

    public Stack<Memento> UndoMementos()
    {
        return _undoMementos;
    }

    public Stack<Memento> Mementos()
    {
        return _mementos;
    }
}