using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility5Demo.Step1_Interface
{
    public abstract class Handler
    {
        private Handler _nextHandler;
        public Handler SetNext(Handler handler)
        {
            _nextHandler = handler;
            return _nextHandler;
        }
        // we do it because dynamically set the next Handler
        // if we check ChainOfResponsibility4Demo you will see 
        // in step2-Concrete Handlers we set the next 
        public void Handle(DomainRequest request)
        {
            if (!ExecutedTask(request))
            {
                return;
            }

            _nextHandler?.Handle(request);
        }

        public abstract bool ExecutedTask(DomainRequest request);
    }
}
