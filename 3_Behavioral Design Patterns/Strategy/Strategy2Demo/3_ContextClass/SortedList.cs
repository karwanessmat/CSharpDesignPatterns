using System;
using System.Collections.Generic;
using Strategy2Demo._1_Define_Strategy_Interface;

namespace Strategy2Demo._3_ContextClass;

/// <summary>
/// The 'Context' class
/// </summary>
class SortedList
{
    private readonly List<string> _list = new();
    private SortStrategy _sortStrategy; // = new SortStrategy() // we can not because we can not create instance for abstract class or interface

    public void SetSortStrategy(SortStrategy sortStrategy)
    {
        _sortStrategy = sortStrategy;
    }

    public void Add(string name)
    {
        _list.Add(name);
    }

    public void Sort()
    {

        _sortStrategy.Sort(_list);

        // Iterate over list and display results

        foreach (string name in _list)
        {
            Console.WriteLine($" {name}");   
        }

        Console.WriteLine("++++++++++++++");

    }
}