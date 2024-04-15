using System;
using Adapter2Demo.step1___Client_Interface;
using Adapter2Demo.step2_Adapter_Class;
using Adapter2Demo.Step3__Adaptee;

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
