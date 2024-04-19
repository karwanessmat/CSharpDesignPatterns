namespace Proxy8Demo._1.Subject_Interface;

internal interface IDataService
{
    Task<List<string>> GetData();
    void InsertData(string item);
}