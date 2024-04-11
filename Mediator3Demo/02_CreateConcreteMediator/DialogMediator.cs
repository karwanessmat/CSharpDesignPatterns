using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator3Demo._01_DefineMediatorInterface;
using Mediator3Demo._03_DefineComponentBaseClass;
using Mediator3Demo._04_CreateConcreteComponents;

namespace Mediator3Demo._02_CreateConcreteMediator;
public class DialogMediator() : IMediator
{
    public Button? Button { get; set; }
    public TextField? TextField { get; set; }
    public void Notify(Control sender, string @event)
    {
        Console.WriteLine(sender);
        if (sender is Button && @event == "click")
        {
            Console.WriteLine("DialogMediator reacts on button click and triggers:");
            TextField?.EnterText("Default Text");
        }

        else if (sender is TextField && @event == "textChange")
        {
            Console.WriteLine("DialogMediator reacts on text change and triggers some action.");
        }
    }
}