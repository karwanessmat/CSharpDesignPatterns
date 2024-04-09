using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChainOfResponsibility0Demo.Step1_Interface;

namespace ChainOfResponsibility0Demo.step2_Concrete_Handlers;

public class ConcreteHandler1:IHandler
{
    private IHandler _nextHandler;
    public IHandler SetNext(IHandler handler)
    {
        _nextHandler = handler;
        return handler;
    }

    public void HandleRequest(string request)
    {
        if (request == "Condition1")
        {
            Console.WriteLine("Handled by ConcreteHandler1");
        }
        else
        {
            Console.WriteLine($"class {GetType().Name}");
            Thread.Sleep(1000);
            _nextHandler?.HandleRequest(request);
        }
    }
}