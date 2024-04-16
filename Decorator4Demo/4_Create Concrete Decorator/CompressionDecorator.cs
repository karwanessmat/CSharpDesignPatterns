using System.Text;
using Decorator4Demo._1_Component_Interface;
using Decorator4Demo._3__Create_an_Abstract_Decorator;

namespace Decorator4Demo._4_Create_Concrete_Decorator;

public class CompressionDecorator(ITextProcessor processor) : TextProcessorDecorator(processor)
{
    public override string? Process(string? input)
    {
        // Simulate compression (just a placeholder example)
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(base.Process(input)));
    }
}