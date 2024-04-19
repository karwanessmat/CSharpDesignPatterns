using Decorator4Demo._1_Component_Interface;

namespace Decorator4Demo._3__Create_an_Abstract_Decorator;
    public abstract class TextProcessorDecorator(ITextProcessor textProcessor):ITextProcessor
    {
        public virtual string? Process(string? input)
        {
            return textProcessor.Process(input);
        }
    }

