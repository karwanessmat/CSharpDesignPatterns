using Proxy2Demo._1._Subject_Interface;
using Proxy2Demo._2.RealSubject;

namespace Proxy2Demo._3.Proxy
{
    internal class ProxyApi
    {
         IPrice _price;

         public int GetCurrentGoldPrices(bool getPrice)
         {
             if (!getPrice) return 0;
             _price =new GoldPrice();
             return _price.GetPrice();
         }
    }
}
