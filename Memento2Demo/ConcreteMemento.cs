using System;

namespace Memento2Demo
{
    // The Concrete Memento contains the infrastructure for storing the
    // Originator's state.
    public class ConcreteMemento : IMemento
    {
        private readonly string _state;

        private readonly DateTime _date;

        public ConcreteMemento(string state)
        {
            this._state = state;
            this._date = DateTime.Now;
        }

        // The Originator uses this method when restoring its state.
        public string GetState()
        {
            return this._state;
        }

        // The rest of the methods are used by the Caretaker to display
        // metadata.
        public string GetName()
        {
            return $"{this._date} / ({this._state.Substring(0, 9)})...";
        }

        public DateTime GetDate()
        {
            return this._date;
        }
    }
}
