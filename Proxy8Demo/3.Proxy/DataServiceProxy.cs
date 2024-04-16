namespace Proxy8Demo;

internal class DataServiceProxy : IDataService
{
    private readonly DataService _dataService = new();
    private List<string>? _localCache = null;

    public async Task<List<string>> GetData()
    {
        Console.WriteLine($"{DateTime.Now} - Started data query.");

        if (_localCache is null)
            _localCache = await _dataService.GetData();

        Console.WriteLine($"{DateTime.Now} - Data has been retrieved.");
        return _localCache;
    }

    public void InsertData(string item)
    {
        _localCache = null;
        _dataService.InsertData(item);
    }
}