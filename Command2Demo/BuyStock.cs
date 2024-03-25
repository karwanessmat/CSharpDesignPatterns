using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command2Demo
{

    // concrete classes
    public class BuyStock : IOrder
    {
        private readonly Stock _abcStock;

        public BuyStock(Stock abcStock)
        {
            _abcStock = abcStock;
        }

        public void Execute(int value)
        {
            _abcStock.Buy(value);
        }
    }
}
