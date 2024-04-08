using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator5Demo._1.Component;

namespace Decorator5Demo._3.Decorator
{
    public abstract class NotifierDecorator(INotifier notifier):INotifier
    {
        public virtual void Send(string message)
        {
            notifier.Send(message);
        }


    }
}
