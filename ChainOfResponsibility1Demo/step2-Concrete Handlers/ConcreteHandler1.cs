using System;
using ChainOfResponsibility1Demo.Step1_Interface;

namespace ChainOfResponsibility1Demo.step3_Concrete_Handlers
{
    public class ConcreteHandler1 : ChainHandler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 0 && request <= 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handled request {request}");
            }
            else if (Successor == null)
            {
                Successor.HandlerRequest(request);
            }
        }
    }
}
