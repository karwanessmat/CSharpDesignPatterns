using System;

namespace ChainOfResponsibility1Demo
{
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
                successor?.HandlerRequest(request);
            }
        }
    }
}
