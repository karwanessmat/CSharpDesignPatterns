using System.Text;
using Decorator4Demo._1.Component;
using Decorator4Demo._3.Decorator;

namespace Decorator4Demo._4.ConcreteDecorators;

public class EncryptionDecorator(ITextProcessor processor) : TextProcessorDecorator(processor)
{
    public override string? Process(string? input)
    {
        // Simulate encryption (just a placeholder example)
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(base.Process(input) ?? string.Empty)).Reverse().ToString();
    }
}