using System;
using Proxy5Demo._2.RealSubject;
using Proxy5Demo._3.Proxy;

namespace Proxy5Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            SensitiveDocument sensitiveDoc = new SensitiveDocument("Top Secret Document Content");

            // Assuming the user's security level is 4
            SecureDocumentProxy proxy = new SecureDocumentProxy(sensitiveDoc, 4);
            Console.WriteLine(proxy.GetContent()); // Outputs: Access Denied: You do not have the necessary security clearance.

            // Assuming the user's security level is 5
            proxy = new SecureDocumentProxy(sensitiveDoc, 5);
            Console.WriteLine(proxy.GetContent()); // Outputs: Top Secret Document Content
        }
    }

    /// <summary>
    /// The 'Subject interface
    /// </summary>
    public interface IClient
    {
        string GetData();
    }

    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    public class RealClient : IClient
    {
        private readonly string _data;
        public RealClient()
        {
            Console.WriteLine("Real Client: Initialized");
            _data = "Dot Net Tricks";
        }

        public string GetData()
        {
            return _data;
        }
    }

    /// <summary>
    /// The 'Proxy Object' class
    /// </summary>
    public class ProxyClient : IClient
    {
        readonly RealClient _client = new RealClient();
        public ProxyClient()
        {
            Console.WriteLine("ProxyClient: Initialized");
        }

        public string GetData()
        {
            return _client.GetData();
        }
    }

}
