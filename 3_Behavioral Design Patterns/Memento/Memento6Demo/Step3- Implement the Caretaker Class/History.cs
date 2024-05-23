using Memento6Demo.Step1__Create_the_Memento_class;

namespace Memento6Demo.Step3__Implement_the_Caretaker_Class;

public class History
{
    private readonly List<EditorState> _history = [];

    public void Push(EditorState memento)
    {
        _history.Add(memento);
    }

    public EditorState Pop()
    {
        var lastState = _history[^1]; // get last one
        _history.RemoveAt(_history.Count - 1);
        return lastState;
    }
}