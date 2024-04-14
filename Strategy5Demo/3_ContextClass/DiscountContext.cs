using Strategy5Demo._1_Define_Strategy_Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy5Demo._3_ContextClass;
public class DiscountContext(IDiscountStrategy strategy)
{
    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        strategy = discountStrategy;
    }

    public double ApplyDiscount(double saleAmount)
    {
        return saleAmount - strategy.CalculateDiscount(saleAmount);
    }
}
