namespace Bridge6Demo;

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