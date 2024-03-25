using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility1Demo
{
  public abstract  class ChainHandler
    {
       public ChainHandler successor;
        public void SetSuccessor(ChainHandler successor)
        {
            this.successor = successor;
        }
        public abstract void HandlerRequest(int request);
    }
}
