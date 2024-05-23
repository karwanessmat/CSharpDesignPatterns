using Visitor6Demo._4__Implement_Concrete_Elements;

namespace Visitor6Demo._1_Visitor_Interface;

public interface IOperation
{
    void Apply(Button button);
    void Apply(TextBox textBox);
}