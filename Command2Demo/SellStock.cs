using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command2Demo
{
    public class SellStock: IOrder
    {
    private readonly Stock _abcStock;

    public SellStock(Stock abcStock)
    {
        this._abcStock = abcStock;
    }

    public void Execute(int value)
    {
        _abcStock.Sell(value);
    }
    }
}
