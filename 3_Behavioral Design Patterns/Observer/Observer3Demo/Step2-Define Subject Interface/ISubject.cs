using Observer3Demo.Step1_Define_Observer_Interface;

namespace Observer3Demo.Step2_Define_Subject_Interface;

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObserver();
}