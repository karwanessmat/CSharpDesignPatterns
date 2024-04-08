using Decorator4Demo._1.Component;
using Decorator4Demo._2.ConcreteComponents;
using Decorator4Demo._4.ConcreteDecorators;

// concrete component
ITextProcessor textProcessor = new PlainTextProcessor();

// Adding HTML encoding
ITextProcessor htmlEncodedProcessor = new HtmlEncodeDecorator(textProcessor);
Console.WriteLine(htmlEncodedProcessor.Process("Example Test"));


// Adding compression on top of HTML encoding
ITextProcessor compressedProcessor = new CompressionDecorator(htmlEncodedProcessor);
Console.WriteLine(compressedProcessor.Process("Example Text"));

ITextProcessor encryptedProcessor = new EncryptionDecorator(compressedProcessor);
Console.WriteLine(encryptedProcessor.Process("Example text"));

Console.WriteLine();
Console.WriteLine("For Json Decorator");

// Basic JSON processing
ITextProcessor jsonProcessor = new JsonTextProcessor();
Console.WriteLine(jsonProcessor.Process("Example text"));

// Adding HTML encoding to JSON output
ITextProcessor htmlEncodedJsonProcessor = new HtmlEncodeDecorator(jsonProcessor);
Console.WriteLine(htmlEncodedJsonProcessor.Process("Example text"));


// Adding compression to the HTML encoded JSON output
ITextProcessor compressedHtmlEncodedJsonProcessorForJson = new CompressionDecorator(jsonProcessor);
Console.WriteLine(compressedHtmlEncodedJsonProcessorForJson.Process("Example text"));

// Adding compression to the HTML encoded JSON output
ITextProcessor compressedHtmlEncodedJsonProcessor = new CompressionDecorator(htmlEncodedJsonProcessor);
Console.WriteLine(compressedHtmlEncodedJsonProcessor.Process("Example text"));