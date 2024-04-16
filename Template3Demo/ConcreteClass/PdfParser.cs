using Template3Demo.AbstractClass;

namespace Template3Demo.ConcreteClass;
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