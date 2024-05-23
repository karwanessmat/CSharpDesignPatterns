using Mediator6Demo._01_DefineMediatorInterface;
using Mediator6Demo._03_DefineComponentBaseClass;

namespace Mediator6Demo._04_CreateConcreteComponents;

public class Button(IWindow owner) : Control(owner)
{
    private bool isEnabled;

    public bool IsEnabled
    {
        get => isEnabled; set
        {
            isEnabled = value;
            owner.Changed(this);
        }
    }
}