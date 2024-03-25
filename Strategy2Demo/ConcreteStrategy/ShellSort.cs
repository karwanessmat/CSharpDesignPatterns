using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy2Demo.Strategy;

namespace Strategy2Demo.ConcreteStrategy
{
    class ShellSort:SortStrategy
    {
        public override void Sort(List<string> list)
        {
            Console.WriteLine("Shell Sorted List");
        }
    }



    /// <summary>
    /// A 'ConcreteStrategy' class
    /// </summary>
    public class MergeSort : SortStrategy
    {
        public override void Sort(List<string> list)
        {
            //list.MergeSort(); not-implemented
            Console.WriteLine("MergeSorted list ");
        }
    }

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

}
