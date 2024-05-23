using System;
using Proxy1Demo._2.RealSubject;
using Proxy1Demo._3.Proxy;
using Proxy1Demo._4.Client;

namespace Proxy1Demo;

class Program
{
    static void Main(string[] args)
    {
        Client client = new Client();

        Console.WriteLine("Client: Executing the client code with a real subject:");
        RealSubject realSubject = new RealSubject();
        client.ClientCode(realSubject);

        Console.WriteLine();

        Console.WriteLine("Client: Executing the same client code with a proxy:");
        Proxy proxy = new Proxy(realSubject);
        client.ClientCode(proxy);


        Console.ReadLine();
    }
}