using System;
using Memento2Demo.Step2__Define_the_Originator_class;
using Memento2Demo.Step3__Implement_the_Caretaker_Class;

namespace Memento2Demo;

class Program
{
    static void Main(string[] args)
    {
        // Client code.
        var originator = new Originator("Step");
        var caretaker = new Caretaker(originator);

        caretaker.Backup();

        originator.DoSomething();
        caretaker.Backup();
        Console.WriteLine();

        originator.DoSomething();
        caretaker.Backup();
        Console.WriteLine();


        originator.DoSomething();

        Console.WriteLine();
        caretaker.ShowHistory();

        Console.WriteLine("\nClient: Now, let's rollback!\n");
        caretaker.Undo();

        Console.WriteLine("\n\nClient: Once more!\n");
        caretaker.Undo();

        Console.WriteLine();
    }
}