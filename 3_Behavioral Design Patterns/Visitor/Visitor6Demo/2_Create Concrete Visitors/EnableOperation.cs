using Visitor6Demo._1_Visitor_Interface;
using Visitor6Demo._4__Implement_Concrete_Elements;

namespace Visitor6Demo._2_Create_Concrete_Visitors;

public class EnableOperation : IOperation
{
    public void Apply(Button button)
    {
        Console.WriteLine($"Enabling {button.Name}");
    }

    public void Apply(TextBox textBox)
    {
        Console.WriteLine($"Enabling {textBox.Name}");
    }
}