using System;
using Memento2Demo.Step1__Create_the_Memento_class;

namespace Memento2Demo.Step2__Define_the_Originator_class
{

    // The Originator holds some important state that may change over time. It
    // also defines a method for saving the state inside a memento and another
    // method for restoring the state from it.
   public class Originator
    {
        // For the sake of simplicity, the originator's state is stored inside a
        // single variable.
        private string _state;
        private int step = 1;
        public Originator(string state)
        {
            _state = state;
            Console.WriteLine($"Current stat: {_state} {step}");
        }

        // The Originator's business logic may affect its internal state.
        // Therefore, the client should backup the state before launching
        // methods of the business logic via the save() method.
        public void DoSomething()
        {
            Console.WriteLine("Originator: I'm doing something important.");
            _state = $" updated {_state} {step++}";
            Console.WriteLine($"{_state}");
        }


        // Saves the current state inside a memento.
        public IMemento SaveStateToMemento()
        {
            var memento = new ConcreteMemento(_state);
            return memento;
        }

        // Restores the Originator's state from a memento object.
        public void Restore(IMemento memento)
        {
            if (!(memento is ConcreteMemento))
            {
                throw new Exception("Unknown memento class " + memento.ToString());
            }

            _state = memento.GetState();
            Console.Write($"Originator: My state has changed to: {_state}");
        }
    }
}
