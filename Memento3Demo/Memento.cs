namespace Memento3Demo
{
    /// <summary>
    ///  Memento  (Memento)
    /// - stores internal state of the Originator object. The memento may store as much or
    ///   as little of the originator's internal state as necessary at its originator's
    ///    discretion.
    /// 
    /// - protect against access by objects of other than the originator. Mementos have effectively
    ///   two interfaces.Caretaker sees a narrow interface to the Memento -- it can only pass the memento to
    ///   the other objects.Originator, in contrast, sees a wide interface, one that lets it access all
    ///   the data necessary to restore itself to its previous state.Ideally, only the originator that
    ///   produces the memento would be permitted to access the memento's internal state.
    /// </summary>

    public class Memento(string state)
    {
        // Constructor

        // Gets or sets state
        public string State { get; } = state;
    }
}
