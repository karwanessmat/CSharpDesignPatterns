using System.Collections.Generic;
using Iterator3Demo.Step1_Iterator_Interface.IteratorDesignPattern;
using Iterator3Demo.Step2_Concrete_Iterator;
using Iterator3Demo.Step3_Collection_Interface;

namespace Iterator3Demo.step4_Concrete_Collection
{
    namespace IteratorDesignPattern
    {
      public  class EmployeeCollection : IAbstractCollection
        {
            private readonly List<Employee> _listEmployees = new();

            //Create Iterator
            public IAbstractIterator CreateIterator()
            {
                return new Iterator(this);
            }

            // Gets item count
            public int Count => _listEmployees.Count;

            //Add items to the collection
            public void AddEmployee(Employee employee)
            {
                _listEmployees.Add(employee);
            }

            //Get item from collection
            public Employee GetEmployee(int indexPosition)
            {
                return _listEmployees[indexPosition];
            }
        }
    }
}
