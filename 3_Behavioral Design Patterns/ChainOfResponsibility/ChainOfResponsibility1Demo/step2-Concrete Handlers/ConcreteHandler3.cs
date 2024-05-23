using System;
using ChainOfResponsibility1Demo.Step1_Interface;

namespace ChainOfResponsibility1Demo.step2_Concrete_Handlers;

public  class ConcreteHandler3:ChainHandler
{
    public override void HandlerRequest(int request)
    {
        if (request>=21 && request<=30)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else
        {
            Successor?.HandlerRequest(request);
        }
    }
}