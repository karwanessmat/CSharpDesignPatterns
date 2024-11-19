using Proxy8Demo._1.Subject_Interface;
using Proxy8Demo._2.RealSubject;

namespace Proxy8Demo._3.Proxy;

internal class DataServiceProxy : IDataService
{
    private readonly DataService _dataService = new();
    private List<string>? _localCache = null;

    public async Task<List<string>> GetData()
    {
        Console.WriteLine($"{DateTime.Now} - Started data query.");

        _localCache ??= await _dataService.GetData();

        Console.WriteLine($"{DateTime.Now} - Data has been retrieved.");
        return _localCache;
    }

    public void InsertData(string item)
    {
        _localCache = null;
        _dataService.InsertData(item);
    }
}