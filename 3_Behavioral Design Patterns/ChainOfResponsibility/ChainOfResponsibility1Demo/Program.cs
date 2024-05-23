using System;
using ChainOfResponsibility1Demo.Step1_Interface;
using ChainOfResponsibility1Demo.step2_Concrete_Handlers;

namespace ChainOfResponsibility1Demo;

class Program
{
    static void Main(string[] args)
    {
        //Set Up the Chain
        ChainHandler h1 = new ConcreteHandler1();
        ChainHandler h2 = new ConcreteHandler2();
        ChainHandler h3 = new ConcreteHandler3();


        h1.SetSuccessor(h2);
        h2.SetSuccessor(h3);


        int[] requests = { 2,  14,5, 22, 18, 3, 27, 20 };

        foreach (int request in requests)
        {
            h1.HandlerRequest(request);
        }

        // Wait for user
        Console.ReadKey();


    }
}