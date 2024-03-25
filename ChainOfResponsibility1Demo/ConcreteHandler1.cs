using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1Demo
{
    public class ConcreteHandler1 : ChainHandler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 0 && request <= 10)
            {
                Console.WriteLine($"{this.GetType().Name} Handled request {request}");
            }
            else if (successor == null)
            {
                successor.HandlerRequest(request);
            }
        }
    }
}
