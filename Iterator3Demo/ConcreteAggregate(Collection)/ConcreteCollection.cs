namespace Iterator3Demo
{
    using System.Collections.Generic;

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
