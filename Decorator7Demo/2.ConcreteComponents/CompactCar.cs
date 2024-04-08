using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator7Demo._1.Component;

namespace Decorator7Demo._2.ConcreteComponents;

public class CompactCar : Car
{
    public CompactCar()
    {
        Description = "Compact Car";
    }

    public override string GetDescription() => Description;
    public override double GetCarPrice() => 10000.00;
}