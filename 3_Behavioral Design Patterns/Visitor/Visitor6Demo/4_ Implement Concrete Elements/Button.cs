using Visitor6Demo._1_Visitor_Interface;
using Visitor6Demo._3_Define_the_Element_Interface;

namespace Visitor6Demo._4__Implement_Concrete_Elements;

public class Button(string name) : Control(name)
{
    public override void Execute(IOperation operation)
    {
        operation.Apply(this);
    }
}