using Observer0Demo.Step1_Define_Observer_Interface;
using Observer0Demo.Step2_Define_Subject_Interface;

namespace Observer0Demo.Step3_Implement_Concrete_Subject;

internal class Publisher(string name) : ISubject
{
    private readonly List<IObserver> _observers = [];

    public string Name => name;

    public void Subscribe(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Unsubscribe(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(this, message);
        }
    }
}