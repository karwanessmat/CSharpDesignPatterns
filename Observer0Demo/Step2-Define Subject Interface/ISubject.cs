using Observer0Demo.Step1_Define_Observer_Interface;

namespace Observer0Demo.Step2_Define_Subject_Interface;

internal interface ISubject
{
    string Name { get; }
    void Subscribe(IObserver observer);
    void Unsubscribe(IObserver observer);
    void Notify(string message);
}