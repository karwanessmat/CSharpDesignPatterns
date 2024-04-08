using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator1Demo._1.Component;

namespace Decorator1Demo._2.ConcreteComponent
{
    public class ConcreteComponent:IComponent
    {
        public string Operation()
        {
            return "ConcreteComponent";
        }
    }
}
