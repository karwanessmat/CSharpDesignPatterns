using Observer7Demo.Step1_Define_Observer_Interface;

namespace Observer7Demo.Step2_Define_Subject_Interface_or_Abstract;

public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}
