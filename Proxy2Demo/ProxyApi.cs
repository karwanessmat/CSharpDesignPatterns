namespace Proxy2Demo
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
