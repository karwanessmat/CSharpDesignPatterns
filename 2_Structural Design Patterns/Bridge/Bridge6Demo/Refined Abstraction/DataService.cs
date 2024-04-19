using Bridge6Demo._1_Define_Implementor_Interface;

namespace Bridge6Demo.Refined_Abstraction;

/// <summary>
/// // Refined Abstraction
/// </summary>
public class DataService : IDataService
{
    private readonly List<string> _data = [];

    public List<string> GetData()
    {
        return _data;
    }

    public void InsertData(string item)
    {
        _data.Add(item);
    }
}