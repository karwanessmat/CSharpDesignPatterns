using System;
using ChainOfResponsibility1Demo.Step1_Interface;

namespace ChainOfResponsibility1Demo.step2_Concrete_Handlers
{
   public class ConcreteHandler2:ChainHandler
    {
        public override void HandlerRequest(int request)
        {
            if (request>=11 && request<=20)
            {
                Console.WriteLine($"{this.GetType().Namespace} handled request {request}");
            }else if (Successor == null)
            {
                Successor?.HandlerRequest(request);
            }
        }
    }
}
