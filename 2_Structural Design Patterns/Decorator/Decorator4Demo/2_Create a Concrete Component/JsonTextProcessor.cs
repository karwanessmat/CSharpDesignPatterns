using Decorator4Demo._1_Component_Interface;

namespace Decorator4Demo._2_Create_a_Concrete_Component;

public class JsonTextProcessor:ITextProcessor
{
    public string? Process(string? input)
    {
        // Simulate JSON processing
        return $"{{\"data\":\"{input}\"}}";
    }
}