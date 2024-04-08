using Decorator4Demo._1.Component;

namespace Decorator4Demo._2.ConcreteComponents;

public class JsonTextProcessor:ITextProcessor
{
    public string? Process(string? input)
    {
        // Simulate JSON processing
        return $"{{\"data\":\"{input}\"}}";
    }
}