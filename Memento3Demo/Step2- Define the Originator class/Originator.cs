using Memento3Demo.Step1__Create_the_Memento_class;

namespace Memento3Demo.Step2__Define_the_Originator_class
{


    /// <summary>
    ///  Originator  (SalesProspect)
    ///   -creates a memento containing a snapshot of its current internal state.
    ///   -uses the memento to restore its internal state
    /// </summary>

  public class Originator
    {
        // Property
        public string State { get; set; }

        // Creates memento 
        public Memento CreateMemento()
        {
            var memento = new Memento(State);
            return memento;
        }


        // Restores original state
        public void SetMemento(Memento memento)
        {
            State = memento.State;
        }
    }

}
