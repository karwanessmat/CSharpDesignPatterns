namespace Memento4Demo.Step1__Create_the_Memento_class;

public class Memento(string text, int curX, int curY)
{
    // Constructor for creating a new Memento with given state

    // Accessors to get the state for the Originator when needed to restore
    public string GetText()
    {
        return text;
    }

    public int GetCursorX()
    {
        return curX;
    }

    public int GetCursorY()
    {
        return curY;
    }
}