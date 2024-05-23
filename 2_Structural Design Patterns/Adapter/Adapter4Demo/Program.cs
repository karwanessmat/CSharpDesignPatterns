using Adapter4Demo.step2_Adapter_Class;
using Adapter4Demo.Step3_Client___Adaptee;

namespace Adapter4Demo;

internal class Program
{
    static void Main(string[] args)
    {
        var xmlConverter = new XmlConverter();

        var adapter = new XmlToJsonAdapter(xmlConverter);
        adapter.ConvertXmlToJson();
    }
}