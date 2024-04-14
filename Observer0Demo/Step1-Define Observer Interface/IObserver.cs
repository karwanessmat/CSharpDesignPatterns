using Observer0Demo.Step2_Define_Subject_Interface;

namespace Observer0Demo.Step1_Define_Observer_Interface;

internal interface IObserver
{
    void Update(ISubject subject, string message);
}