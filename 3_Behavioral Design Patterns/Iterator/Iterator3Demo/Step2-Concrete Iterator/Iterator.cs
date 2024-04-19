using Iterator3Demo.Step1_Iterator_Interface.IteratorDesignPattern;
using Iterator3Demo.step4_Concrete_Collection.IteratorDesignPattern;

namespace Iterator3Demo.Step2_Concrete_Iterator
{

      public class Iterator(EmployeeCollection employees) : IAbstractIterator
      {
            private int _current;
            private const int Step = 1;

            // Constructor

            // Gets first item
            public Employee First()
            {
                _current = 0;
                return employees.GetEmployee(_current);
            }

            // Gets next item
            public Employee Next()
            {
                
                return !IsCompleted ? employees.GetEmployee(_current++) : null;
            }

            // Check whether iteration is complete
            public bool IsCompleted => _current >= employees.Count;
        }
    
}
