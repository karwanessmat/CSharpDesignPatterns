using Bridge6Demo._1_Define_Implementor_Interface;

namespace Bridge6Demo._3_Define_Abstraction;

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