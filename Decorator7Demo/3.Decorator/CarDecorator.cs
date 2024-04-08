using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator7Demo._1.Component;

namespace Decorator7Demo._3.Decorator
{
    public class CarDecorator(Car car):Car
    {
        public override string GetDescription()
        {
            return car.GetDescription();
        }

        public override double GetCarPrice()
        {
           return car.GetCarPrice();
        }
    }
}
