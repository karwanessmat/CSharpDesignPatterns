using Mediator3Demo._03_DefineComponentBaseClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator3Demo._01_DefineMediatorInterface;

namespace Mediator3Demo._04_CreateConcreteComponents;

public class Button(IMediator mediator): Control(mediator)
{
    public void Click()
    {
        Console.WriteLine("Button Clicked");
        Mediator.Notify(this, "click");
    }
}