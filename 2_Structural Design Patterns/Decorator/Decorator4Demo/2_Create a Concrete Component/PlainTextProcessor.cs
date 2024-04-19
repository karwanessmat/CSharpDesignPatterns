using Decorator4Demo._1_Component_Interface;

namespace Decorator4Demo._2_Create_a_Concrete_Component;
    public class PlainTextProcessor:ITextProcessor
    {
        public string? Process(string? input)
        {
            return input;
        }
    }