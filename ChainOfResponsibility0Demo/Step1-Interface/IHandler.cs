using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility0Demo.Step1_Interface
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void HandleRequest(string request);
    }
}
