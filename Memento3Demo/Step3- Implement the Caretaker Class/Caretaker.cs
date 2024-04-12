using System.Collections.Generic;
using Memento3Demo.Step1__Create_the_Memento_class;

namespace Memento3Demo.Step3__Implement_the_Caretaker_Class
{
    /// <summary>
    ///  Caretaker  (Caretaker)
    /// - is responsible for the memento's safekeeping
    /// - never operates on or examines the contents of a memento.
    /// </summary>

   public class Caretaker
   {
       private readonly List<Memento> _mementoList = [];
        
       // Gets or sets memento
       private Memento _memento;
        public Memento Memento {
            get => _memento;
            set
            {
                _memento = value;
                _mementoList.Add(Memento);
            } }

        public void Add(Memento state)
        {
            _mementoList.Add(state);
        }
        public List<Memento> GetMementoHistory()
        {
            return _mementoList;
        }


        public Memento GetMementoStep(int index)
        {
            return _mementoList[index-1];
        }
    }
}
