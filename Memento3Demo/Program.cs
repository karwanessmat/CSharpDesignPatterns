using System;

namespace Memento3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator o = new Originator();
            o.State = "On";

            // Store internal state

            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator

            o.State = "Off";

            // Restore saved state

            o.SetMemento(c.Memento);

            // Wait for user

            Console.ReadKey();
        }
    }
}
