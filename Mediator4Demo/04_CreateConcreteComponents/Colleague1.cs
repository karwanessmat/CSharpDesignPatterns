using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator4Demo._01_DefineMediatorInterface;
using Mediator4Demo._03_DefineComponentBaseClass;

namespace Mediator4Demo._04_CreateConcreteComponents
{
    public class Colleague1 : Colleague
    {
        //public Colleague1(Mediator mediator) : base(mediator)
        //{
        //}
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague1 receives notification message: {message}");
        }
    }
}
