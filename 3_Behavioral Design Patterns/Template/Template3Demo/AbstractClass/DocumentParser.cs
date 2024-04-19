namespace Template3Demo.AbstractClass;
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