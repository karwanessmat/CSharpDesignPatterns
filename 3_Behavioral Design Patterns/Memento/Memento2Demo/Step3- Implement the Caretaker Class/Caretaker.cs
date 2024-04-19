using System;
using System.Collections.Generic;
using System.Linq;
using Memento2Demo.Step1__Create_the_Memento_class;
using Memento2Demo.Step2__Define_the_Originator_class;

namespace Memento2Demo.Step3__Implement_the_Caretaker_Class
{
    // The Caretaker doesn't depend on the Concrete Memento class. Therefore, it
    // doesn't have access to the originator's state, stored inside the memento.
    // It works with all mementos via the base Memento interface.
    public class Caretaker(Originator originator)
    {
        private readonly List<IMemento> _mementos = [];

        public void Backup()
        {
            var memento = originator.SaveStateToMemento();
            _mementos.Add(memento);
            Console.WriteLine("Saved stated");
        }

        public void Undo()
        {
            if (_mementos.Count == 0)
            {
                return;
            }

            var memento = _mementos.Last() as ConcreteMemento;

            _mementos.Remove(memento);

            Console.WriteLine("Caretaker: Restoring state to: " + memento?.GetName());

            try
            {
                
                originator.Restore(memento);
            }
            catch (Exception)
            {
                Undo();
            }
        }

        public void ShowHistory()
        {
            Console.WriteLine("Caretaker: Here's the list of mementos:");

            foreach (var memento in _mementos)
            {
                Console.WriteLine(memento.GetName());
            }
        }
    }
}
