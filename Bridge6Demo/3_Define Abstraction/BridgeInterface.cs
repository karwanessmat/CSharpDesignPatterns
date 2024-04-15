namespace Bridge6Demo;

/// <summary>
/// Abstract
/// </summary>
internal class BridgeInterface
{
    /// <summary>
    /// Bridge
    /// </summary>
    public IDataService? Implementation { get; set; }

    public void GetData()
    {
        if (Implementation is null)
        {
            Console.WriteLine("No data.");
            return;
        }

        foreach (var item in Implementation.GetData())
        {
            Console.WriteLine(item);
        }
    }

    public void InsertData(string item)
    {
        Implementation?.InsertData(item);
    }
}