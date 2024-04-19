using System;
using System.Threading;
using ChainOfResponsibility3Demo.Step1_Interface;

namespace ChainOfResponsibility3Demo.step2_Concrete_Handlers;

public class TeamTwo(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
{
    public override void HandleRequest()
    {
        Console.WriteLine("Waiting for team two to respond");

        Thread.Sleep(10000);

        if (true)
        {
            Console.WriteLine($"Question was answered by {GetType().Name}, no needs next teams answering!");
            return;
        }
        Console.WriteLine("\t no response from team two.....");
        NextTeam.HandleRequest();
    }
}