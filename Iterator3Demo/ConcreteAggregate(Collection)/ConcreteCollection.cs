using System.Collections.Generic;
using Iterator3Demo.Aggregate_AbstractCollection_;
using Iterator3Demo.ConcreteIterator_Iterator_;

namespace Iterator3Demo.ConcreteAggregate_Collection_
{
    namespace IteratorDesignPattern
    {
      public  class ConcreteCollection : IAbstractCollection
        {
            private readonly List<Employee> _listEmployees = new List<Employee>();

            //Create Iterator
            public Iterator CreateIterator()
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
