using System;
using Memento3Demo.Step1__Create_the_Memento_class;
using Memento3Demo.Step2__Define_the_Originator_class;
using Memento3Demo.Step3__Implement_the_Caretaker_Class;

namespace Memento3Demo;

class Program
{
    static void Main(string[] args)
    {
        Originator originator = new Originator();
        var caretaker = new Caretaker();


        originator.SetMemento(new Memento("On1"));
        var savedMemento = originator.CreateMemento();
        caretaker.Add(savedMemento);


        originator.SetMemento(new Memento("Off2"));
        savedMemento = originator.CreateMemento();
        caretaker.Add(savedMemento);


        originator.SetMemento(new Memento("On3"));
        savedMemento = originator.CreateMemento();
        caretaker.Add(savedMemento);


        originator.SetMemento(new Memento("Off4"));
        savedMemento = originator.CreateMemento();
        caretaker.Add(savedMemento);



        originator.SetMemento(new Memento("On5"));
        savedMemento = originator.CreateMemento();
        caretaker.Add(savedMemento);




        foreach (var memento in caretaker.GetMementoHistory())
        {
            Console.WriteLine($"State: {memento.State}");
        }

        Console.WriteLine(caretaker.GetMementoStep(5).State);



        Console.ReadKey();
    }
}