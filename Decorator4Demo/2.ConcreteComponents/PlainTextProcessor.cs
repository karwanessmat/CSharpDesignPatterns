using Decorator4Demo._1.Component;

namespace Decorator4Demo._2.ConcreteComponents;
    public class PlainTextProcessor:ITextProcessor
    {
        public string? Process(string? input)
        {
            return input;
        }
    }