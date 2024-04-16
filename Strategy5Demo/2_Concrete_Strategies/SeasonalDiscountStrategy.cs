using Strategy5Demo._1_Define_Strategy_Interface;

namespace Strategy5Demo._2_Concrete_Strategies;

public class SeasonalDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        // Example: 15% seasonal discount
        return saleAmount * 0.15;
    }
}