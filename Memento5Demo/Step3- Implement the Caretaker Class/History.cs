using Memento5Demo.Step1__Create_the_Memento_class;
using Memento5Demo.Step2__Define_the_Originator_class;

namespace Memento5Demo.Step3__Implement_the_Caretaker_Class;

public class History
{
    private readonly Stack<EditorMemento> _mementos = new();  // Stack to hold mementos

    public void Save(Editor editor)  // Save a new state
    {
        _mementos.Push(editor.Save());
    }

    public void Undo(Editor editor)  // Restore the most recent state
    {
        if (_mementos.Count > 0)
        {
            editor.Restore(_mementos.Pop());
        }
        else
        {
            Console.WriteLine("No more undos available.");
        }
    }
}