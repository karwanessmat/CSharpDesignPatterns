using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator7Demo._1.Component;
using Decorator7Demo._3.Decorator;

namespace Decorator7Demo._4.ConcreteDecorators;
public class LeatherSeats : CarDecorator
{
    private readonly Car _car;
    public LeatherSeats(Car car)
        : base(car)
    {
        this._car= car;
        Description = "Leather Seats";
    }

    public override string GetDescription() => $"{_car.GetDescription()}, {Description}";
    public override double GetCarPrice() => base.GetCarPrice() + 2500;
}
