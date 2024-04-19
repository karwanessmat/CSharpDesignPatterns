using Memento4Demo.Step1__Create_the_Memento_class;

namespace Memento4Demo.Step2__Define_the_Originator_class;

public class Editor
{
    private string _text = "";
    private int _curX = 0;
    private int _curY = 0;

    // Method to change the text in the editor
    public void SetText(string newText)
    {
        _text = newText;
    }

    // Method to move the cursor within the text
    public void SetCursor(int x, int y)
    {
        _curX = x;
        _curY = y;
    }

    // Save the current state to a memento
    public Memento CreateMemento()
    {
        return new Memento(_text, _curX, _curY);
    }

    // Restore the state from a memento
    public void RestoreState(Memento memento)
    {
        _text = memento.GetText();
        _curX = memento.GetCursorX();
        _curY = memento.GetCursorY();
    }

    // Display the current state (for demonstration purposes)
    public void Display()
    {
        Console.WriteLine("Current Content: " + _text);
        Console.WriteLine("Cursor Position: (" + _curX + ", " + _curY + ")");
    }
}