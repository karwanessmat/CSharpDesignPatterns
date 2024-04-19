using System.Collections.Generic;
using Observer1Demo.Step1_Define_Observer_Interface;

namespace Observer1Demo.Step2_Define_Subject_Interface
{


    /// <summary>
    /// Step 2: Define the Subject Interface: This interface manages the list of observers and includes methods for adding, removing, and notifying observers.
    /// </summary>
    public abstract class Subject
    {
        private readonly List<Observer> _observers =[];
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (var o in _observers)
            {
                o.Update();
            }
        }
    }
}
