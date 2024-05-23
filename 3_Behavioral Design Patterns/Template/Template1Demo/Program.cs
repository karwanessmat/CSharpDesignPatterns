using System;
using Template1Demo._1_AbstractClass;
using Template1Demo._2_ConcreteClass;

namespace Template1Demo;

class Program
{
    static void Main(string[] args)
    {

        AbstractClass aA = new ConcreteClassA();
        aA.TemplateMethod();

        AbstractClass aB = new ConcreteClassA();
        aB.TemplateMethod();

        Console.ReadLine();
    }
}