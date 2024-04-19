using Observer0Demo.Step1_Define_Observer_Interface;
using Observer0Demo.Step2_Define_Subject_Interface;

namespace Observer0Demo.Step4_Implement_Concrete_Observers;

internal class Subscriber(string name) : IObserver
{
    public void Update(ISubject subject, string message)
    {
        Console.WriteLine($"'{message}' message received from {subject.Name} by {name}.");
    }
}