using Observer3Demo.Observer;

namespace Observer3Demo.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObserver();
    }
}
