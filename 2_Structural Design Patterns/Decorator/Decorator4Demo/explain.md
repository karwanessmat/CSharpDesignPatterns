
# Decorator Pattern Example in .NET

This project demonstrates the use of the Decorator design pattern in a .NET application to dynamically add new functionalities to objects. We focus on a text processing system where the core functionality is to process text into JSON format. Additional behaviors like HTML encoding and compression can be dynamically added to the processing flow.

## Overview

The Decorator pattern allows for the dynamic extension of an object's behavior by wrapping it with one or more decorator classes. These decorators add their own behavior either before or after delegating the call to the wrapped object.

## Implementation

The implementation consists of the following components:

### ITextProcessor

An interface representing the text processing operations.

```csharp
public interface ITextProcessor
{
    string Process(string input);
}
```

### JsonTextProcessor

A concrete implementation of `ITextProcessor` that formats the input text as JSON.

```csharp
public class JsonTextProcessor : ITextProcessor
{
    public string Process(string input)
    {
        return $"{{\"data\":\"{input}\"}}";
    }
}
```

### TextProcessorDecorator

An abstract decorator class implementing `ITextProcessor` that holds a reference to a `ITextProcessor` object.

```csharp
public abstract class TextProcessorDecorator : ITextProcessor
{
    protected ITextProcessor _innerProcessor;

    protected TextProcessorDecorator(ITextProcessor processor)
    {
        _innerProcessor = processor;
    }

    public virtual string Process(string input)
    {
        return _innerProcessor.Process(input);
    }
}
```

### Concrete Decorators

Decorators that extend the functionality of `ITextProcessor` objects.

- `HtmlEncodeDecorator`: Adds HTML encoding to the text.
- `CompressionDecorator`: Compresses the text.

```csharp
public class HtmlEncodeDecorator : TextProcessorDecorator
{
    public HtmlEncodeDecorator(ITextProcessor processor) : base(processor) { }

    public override string Process(string input)
    {
        return System.Net.WebUtility.HtmlEncode(base.Process(input));
    }
}

public class CompressionDecorator : TextProcessorDecorator
{
    public CompressionDecorator(ITextProcessor processor) : base(processor) { }

    public override string Process(string input)
    {
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(base.Process(input)));
    }
}
```

## Usage

To use the system, create an instance of `JsonTextProcessor` and then wrap it with any decorators you need.

```csharp
ITextProcessor processor = new JsonTextProcessor();
processor = new HtmlEncodeDecorator(processor);
processor = new CompressionDecorator(processor);

Console.WriteLine(processor.Process("Your text here"));
```

This setup processes the text to JSON, then HTML encodes it, and finally compresses it, demonstrating the flexibility and power of the Decorator pattern.

## Conclusion

The Decorator pattern in this example shows how to extend the functionality of objects in a flexible and scalable manner. By starting with a simple JSON text processing and progressively adding functionalities like HTML encoding and compression, we can see the pattern's ability to enhance object behavior dynamically.
```