using Mediator8Demo._01_DefineMediatorInterface;
using Mediator8Demo._03_DefineComponentBaseClass;

namespace Mediator8Demo._04_CreateConcreteComponents;

public class Checkbox(IMediator mediator) : Component(mediator)
{
    public bool IsChecked { get; set; }

    public void Checked()
    {
        IsChecked = true;
        Mediator.Notify(this, "checked");
    }
}