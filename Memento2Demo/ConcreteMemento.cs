using System;

namespace Memento2Demo
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    public class ConcreteMemento(string state) : IMemento
    {
        private readonly DateTime _date = DateTime.Now;

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{this._date} / ({state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
