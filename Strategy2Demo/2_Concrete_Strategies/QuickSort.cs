using System;
using System.Collections.Generic;
using Strategy2Demo._1_Define_Strategy_Interface;

namespace Strategy2Demo._2_Concrete_Strategies;

/// <summary>
/// A 'ConcreteStrategy' class
/// </summary>
public class QuickSort : SortStrategy
{
    public override void Sort(List<string> list)
    {
        list.Sort();  // Default is Quicksort
        Console.WriteLine("QuickSorted list ");
    }
}