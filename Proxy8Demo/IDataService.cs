namespace Proxy8Demo;

internal interface IDataService
{
    Task<List<string>> GetData();
    void InsertData(string item);
}