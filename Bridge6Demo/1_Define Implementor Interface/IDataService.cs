namespace Bridge6Demo._1_Define_Implementor_Interface;

public interface IDataService
{
    List<string> GetData();
    void InsertData(string item);
}