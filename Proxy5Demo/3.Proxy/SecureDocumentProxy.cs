using Proxy5Demo._1._Subject_Interface;
using Proxy5Demo._2.RealSubject;

namespace Proxy5Demo._3.Proxy;

    public class SecureDocumentProxy(SensitiveDocument sensitiveDocument, int userSecurityLevel) : IDocument
    {
        public string GetContent()
        {
            return userSecurityLevel>=5 
                ? sensitiveDocument.GetContent() 
                : "Access Denied: You do not have the necessary security clearance.";
        }
}

