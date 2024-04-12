using Memento0Demo.Step1__Create_the_Memento_class;

namespace Memento0Demo.Step2__Define_the_Originator_class;
// Originator class
public class Originator
{
    private string? _state;

    public void SetState(string? state)
    {
        _state = state;
    }

    public string? GetState()
    {
        return _state;
    }

    public Memento SaveStateToMemento()
    {
        var memento = new Memento(_state);
        SetState(_state);
        return memento;
    }

    public void GetStateFromMemento(Memento memento)
    {
        _state = memento.GetState();
    }
}