using System;

namespace ChainOfResponsibility1Demo
{
   public class ConcreteHandler2:ChainHandler
    {
        public override void HandlerRequest(int request)
        {
            if (request>=11 && request<=20)
            {
                Console.WriteLine($"{this.GetType().Namespace} handled request {request}");
            }else if (successor == null)
            {
                successor?.HandlerRequest(request);
            }
        }
    }
}
