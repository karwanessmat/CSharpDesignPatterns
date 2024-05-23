using System;
using Proxy2Demo._1._Subject_Interface;

namespace Proxy2Demo._2.RealSubject;

public class GoldPrice:IPrice
{
    public int GetPrice()
    {
        var rand = new Random();
        return rand.Next(1, 99);
    }
}