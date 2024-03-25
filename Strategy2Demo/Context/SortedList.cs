using System;
using System.Collections.Generic;
using Strategy2Demo.Strategy;

namespace Strategy2Demo.Context
{
    /// <summary>
    /// The 'Context' class
    /// </summary>
    class SortedList
    {
        private readonly List<string> _list = new();
        private SortStrategy _sortStrategy;
        public void SetSortStrategy(SortStrategy sortstrategy)
        {
            _sortStrategy = sortstrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void Sort()
        {
            _sortStrategy.Sort(_list);

            // Iterate over list and display results

            foreach (var name in _list)
            {
                Console.WriteLine($" {name}");   
            }

            Console.WriteLine("++++++++++++++");

        }
    }
}
