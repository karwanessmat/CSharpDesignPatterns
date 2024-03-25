using System;
using Template1Demo.ConcreteClass;

namespace Template1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            AbstractClass.AbstractClass aA = new ConcreteClassA();
            aA.TemplateMethod();

            AbstractClass.AbstractClass aB = new ConcreteClassA();
            aB.TemplateMethod();

            Console.ReadLine();
        }
    }
}
