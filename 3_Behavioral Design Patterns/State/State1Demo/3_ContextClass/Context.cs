using System;
using State1Demo._1_CreateStateInterface;

namespace State1Demo._3_ContextClass;

/// <summary>
/// The 'Context' class
/// </summary>
public class Context
{

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

    // Constructor
    public Context(State state)
    {
        State = state;
    }


    public void Request()
    {
        _state.Handler(this);
    }
}