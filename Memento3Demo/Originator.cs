using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento3Demo
{


    /// <summary>
    ///  Originator  (SalesProspect)
    ///   -creates a memento containing a snapshot of its current internal state.
    ///   -uses the memento to restore its internal state
    /// </summary>

  public class Originator
    {
        private string _state;

        // Property
        public string State
        {
            get => _state;
            set

            {
                _state = value;
                Console.WriteLine("State = " + _state);
            }
        }

        // Creates memento 
        public Memento CreateMemento()
        {
            return (new Memento(_state));
        }

        // Restores original state
        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }

}
