using Strategy5Demo._1_Define_Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy5Demo._2_Concrete_Strategies;

public class SeasonalDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        // Example: 15% seasonal discount
        return saleAmount * 0.15;
    }
}