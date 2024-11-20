using Observer7Demo.Step1_Define_Observer_Interface;
using Observer7Demo.Step2_Define_Subject_Interface_or_Abstract;

namespace Observer7Demo.Step3_Implement_Concrete_Subject;

public class WeatherStation : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();
    private int _temperature;

    public int Temperature
    {
        get => _temperature;
        set
        {
            _temperature = value;
            Notify(); // Notify observers about the change
        }
    }

    public void Attach(IObserver observer) => _observers.Add(observer);

    public void Detach(IObserver observer) => _observers.Remove(observer);

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }
}
