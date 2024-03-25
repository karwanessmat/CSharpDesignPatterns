using System;

namespace Proxy2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var proxyApi = new ProxyApi(); // Instantiates the proxy class
            var price = proxyApi.GetCurrentGoldPrices(true);

            Console.WriteLine(price > 0 ? $"Current Gold price is: {price}" : "No call the API");

            Console.WriteLine("_______________");
             price = proxyApi.GetCurrentGoldPrices(false);

             Console.WriteLine(price > 0 ? $"Current Gold price is: {price}" : "No call the API");
        }
    }
}
