using System;

namespace Proxy2Demo
{
   public class GoldPrice:IPrice
    {
        public int GetPrice()
        {
            var rand = new Random();
            return rand.Next(1, 99);
        }
    }
}
