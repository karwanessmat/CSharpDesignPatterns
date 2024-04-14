using Template3Demo.AbstractClass;

namespace Template3Demo.ConcreteClass;

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