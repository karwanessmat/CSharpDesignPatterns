using System;

namespace State1Demo
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    public class Context
    {
        // Constructor
        public Context(State state)
        {
            this.State = state;
        }


        // Gets or sets the state
        State _state;
        public State State
        {
            get => _state;
            set
            {
                _state = value;
                Console.WriteLine("State: " + _state.GetType().Name);
            }
        }
        public void Request()
        {
            _state.Handler(this);
        }
    }
}
