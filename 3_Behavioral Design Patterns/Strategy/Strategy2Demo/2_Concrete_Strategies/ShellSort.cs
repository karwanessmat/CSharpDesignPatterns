using System;
using System.Collections.Generic;
using Strategy2Demo._1_Define_Strategy_Interface;

namespace Strategy2Demo._2_Concrete_Strategies;

class ShellSort:SortStrategy
{
    public override void Sort(List<string> list)
    {
        Console.WriteLine("Shell Sorted List");
    }
}