using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator4Demo._1.Component;

namespace Decorator4Demo._3.Decorator;
    public abstract class TextProcessorDecorator(ITextProcessor textProcessor):ITextProcessor
    {
        public virtual string? Process(string? input)
        {
            return textProcessor.Process(input);
        }
    }

