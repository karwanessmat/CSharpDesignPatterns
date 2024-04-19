namespace Memento5Demo.Step1__Create_the_Memento_class;

public class EditorMemento(string content)
{


    public string GetContent()  // Accessor to get the state
    {
        return content;
    }
}