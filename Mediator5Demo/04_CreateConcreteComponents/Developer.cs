using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator5Demo._01_DefineMediatorInterface;
using Mediator5Demo._03_DefineComponentBaseClass;

namespace Mediator5Demo._04_CreateConcreteComponents
{
    public class Developer(string name) : TeamMember(name)
    {
        public override void Receive(string from, string message)
        {
            Console.Write($"{this.Name} ({nameof(Developer)}) has received: ");
            base.Receive(from, message);
        }
    }
}
