namespace Proxy8Demo;

internal class DataService : IDataService
{
    private readonly List<string> _data = [];

    public async Task<List<string>> GetData()
    {
        // Simulate long-running process
        await Task.Delay(3000);
        return _data;
    }

    public void InsertData(string item)
    {
        _data.Add(item);
    }
}