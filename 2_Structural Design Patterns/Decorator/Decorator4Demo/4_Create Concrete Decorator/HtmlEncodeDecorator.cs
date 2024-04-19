using Decorator4Demo._1_Component_Interface;
using Decorator4Demo._3__Create_an_Abstract_Decorator;

namespace Decorator4Demo._4_Create_Concrete_Decorator;
    public class HtmlEncodeDecorator(ITextProcessor processor) :TextProcessorDecorator(processor)
    {
        public override string? Process(string? input)
        {
            //return base.Process(input);
            return System.Net.WebUtility.HtmlEncode(base.Process(input));

    }
}