using System;

namespace Adapter2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
           ITarget target = new Adapter(adaptee);
           Console.WriteLine(target.Request());

           Console.ReadLine();
        }
    }
}
