using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mediator8Demo._01_DefineMediatorInterface;
using Mediator8Demo._03_DefineComponentBaseClass;

namespace Mediator8Demo._04_CreateConcreteComponents;



public class TextBox : Component
{
    public string Text { get; set; }

    public TextBox(IMediator mediator) : base(mediator) { }

    public void TextChanged()
    {
        Mediator.Notify(this, "textChanged");
    }
}