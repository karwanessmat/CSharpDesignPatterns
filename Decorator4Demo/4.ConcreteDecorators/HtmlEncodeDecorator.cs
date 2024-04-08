using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Decorator4Demo._1.Component;
using Decorator4Demo._3.Decorator;

namespace Decorator4Demo._4.ConcreteDecorators;
    public class HtmlEncodeDecorator(ITextProcessor processor) :TextProcessorDecorator(processor)
    {
        public override string? Process(string? input)
        {
            //return base.Process(input);
            return System.Net.WebUtility.HtmlEncode(base.Process(input));

    }
}