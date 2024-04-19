using Proxy5Demo._1._Subject_Interface;

namespace Proxy5Demo._2.RealSubject;

public class SensitiveDocument(string content) : IDocument
{
    public string GetContent()
    {
        return content;
    }
}