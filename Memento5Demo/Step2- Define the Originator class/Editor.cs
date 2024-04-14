using Memento5Demo.Step1__Create_the_Memento_class;

namespace Memento5Demo.Step2__Define_the_Originator_class;

public class Editor
{
    private string _content = "";  // State of the Originator

    public void Type(string words)  // Method to modify the state
    {
        _content += " " + words;
    }

    public string GetContent()  // Accessor to view the current state
    {
        return _content;
    }

    public EditorMemento Save()  // Saves the current state in a memento
    {
        return new EditorMemento(_content);
    }

    public void Restore(EditorMemento memento)  // Restores the state from the memento
    {
        _content = memento.GetContent();
    }
}