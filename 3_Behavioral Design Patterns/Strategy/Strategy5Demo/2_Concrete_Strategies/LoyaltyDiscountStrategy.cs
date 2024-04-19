using Strategy5Demo._1_Define_Strategy_Interface;

namespace Strategy5Demo._2_Concrete_Strategies;

public class LoyaltyDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        // Example: 10% loyalty card discount
        return saleAmount * 0.10;
    }
}