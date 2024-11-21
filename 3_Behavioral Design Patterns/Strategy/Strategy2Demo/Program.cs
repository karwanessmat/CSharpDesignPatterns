using System;
using Strategy2Demo._2_Concrete_Strategies;
using Strategy2Demo._3_ContextClass;

namespace Strategy2Demo;

class Program
{
    static void Main(string[] args)
    {

        var studentRecords = new SortedList();
        studentRecords.Add("a");
        studentRecords.Add("b");
        studentRecords.Add("aa");
        studentRecords.Add("c");
        studentRecords.Add("bb");
        studentRecords.Add("ba");

        studentRecords.SetSortStrategy(new QuickSort());
        studentRecords.Sort();


        studentRecords.SetSortStrategy(new ShellSort());
        studentRecords.Sort();


        studentRecords.SetSortStrategy(new MergeSort());
        studentRecords.Sort();


        Console.ReadLine();
    }
}