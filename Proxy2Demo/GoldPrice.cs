using System;
using System.Collections.Generic;
using System.Text;

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
