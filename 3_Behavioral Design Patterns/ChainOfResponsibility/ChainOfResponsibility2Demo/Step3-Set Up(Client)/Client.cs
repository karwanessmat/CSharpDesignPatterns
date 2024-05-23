using System;
using System.Collections.Generic;
using ChainOfResponsibility2Demo.Step1_Interface;

namespace ChainOfResponsibility2Demo;

internal class Client
{
    // The client code is usually suited to work with a single handler. In
    // most cases, it is not even aware that the handler is part of a chain.
    public static void ClientCode(AbstractHandler handler)
    {
        foreach (string food in new List<string> { "Nut", "Banana", "Cup of coffee" })
        {
            Console.WriteLine($"Client: Who wants a {food}?");

            object result = handler.Handle(food);

            if (result != null)
            {
                Console.Write($"   {result}");
            }
            else
            {
                Console.WriteLine($"   {food} was left untouched.");
            }
        }
    }
}