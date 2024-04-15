namespace Bridge6Demo;

public interface IDataService
{
    List<string> GetData();
    void InsertData(string item);
}