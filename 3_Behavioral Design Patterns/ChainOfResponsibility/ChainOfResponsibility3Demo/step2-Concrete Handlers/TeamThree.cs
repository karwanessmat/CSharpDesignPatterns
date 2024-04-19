using System;
using System.Threading;
using ChainOfResponsibility3Demo.Step1_Interface;

namespace ChainOfResponsibility3Demo.step2_Concrete_Handlers;

public class TeamThree(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
{
    public override void HandleRequest()
    {
        Console.WriteLine("Waiting for team three to respond");
        Thread.Sleep(5000);

        Console.WriteLine("\t no response from team three as well .....");
    }
}