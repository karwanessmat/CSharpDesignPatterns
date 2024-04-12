namespace Memento0Demo.Step1__Create_the_Memento_class;

// Memento class
public class Memento(string? state)
{
    public string? GetState()
    {
        return state;
    }
}