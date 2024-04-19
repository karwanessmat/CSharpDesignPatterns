# Template Method Pattern Example

## Introduction
It's a design pattern that defines the structure of an algorithm in a superclass but allows subclasses to modify parts of the algorithm without changing its overall structure.
### Frequency of use: `3/5` medium

## Scenario
The example simulates a data mining application that processes various document formats (PDF, DOC, CSV), extracting data while minimizing code duplication across different format handlers.

## Problem
Handling multiple document formats led to significant code duplication, with each format handler sharing much of the same processing logic.

## Solution
The Template Method pattern allows us to define the common algorithm structure in a base class and let subclasses override the steps that differ between formats.

## Project Structure

### Abstract Class
- `DocumentParser`: Defines the template method and abstract methods for steps that vary between implementations.

### Concrete Classes
- `PdfParser`, `DocParser`, `CsvParser`: Implement specific steps required for their respective document formats.

## Steps to Implement

### 1. Define the Steps of the Algorithm
Identify common steps in the algorithm and those that vary by document format.

### 2. Create an Abstract Base Class
Define an abstract class with a template method outlining the algorithm's structure and abstract methods for varying steps.

```csharp
public abstract class DocumentParser
{
    // The template method
    public void ParseDocument()
    {
        OpenFile();
        ExtractData();
        CloseFile();
        AnalyzeData();
    }

    protected abstract void OpenFile();
    protected abstract void ExtractData();
    protected abstract void CloseFile();

    // Common implementation available to all subclasses
    protected virtual void AnalyzeData()
    {
        Console.WriteLine("Analyzing data");
    }
}
```
### ` #A method template that outlines the sequence of steps for the algorithm. This method is final and cannot be changed by subclasses.`
### 3. Implement Concrete Subclasses
Each subclass implements the abstract methods defined in the base class.

```csharp
public class PdfParser : DocumentParser
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening PDF file.");
    }

    protected override void ExtractData()
    {
        Console.WriteLine("Extracting data from PDF.");
    }

    protected override void CloseFile()
    {
        Console.WriteLine("Closing PDF file.");
    }
}

public class DocParser : DocumentParser
{
    protected override void OpenFile()
    {
        Console.WriteLine("Opening DOC file.");
    }

    protected override void ExtractData()
    {
        Console.WriteLine("Extracting data from DOC.");
    }

    protected override void CloseFile()
    {
        Console.WriteLine("Closing DOC file.");
    }
}
```

### 4. Utilize the Template Method
The client code can now use the template method to process documents in a standardized manner.

```csharp
class Program
{
    static void Main(string[] args)
    {
        DocumentParser parser = new PdfParser();
        parser.ParseDocument();
        
        parser = new DocParser();
        parser.ParseDocument();
    }
}
```

## Summary
This example illustrates how the Template Method pattern can simplify the handling of different document formats in a data processing application by defining a common algorithm structure and allowing subclasses to provide specific implementations for steps that vary between formats.
```

This `README.md` provides a comprehensive overview of using the Template Method pattern in a C# project, complete with explanations and code samples to guide users through the implementation process.