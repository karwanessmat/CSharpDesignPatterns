using Strategy5Demo._1_Define_Strategy_Interface;

namespace Strategy5Demo._2_Concrete_Strategies;

public class PromotionalDiscountStrategy : IDiscountStrategy
{
    public double CalculateDiscount(double saleAmount)
    {
        // Example: 25% promotional discount
        return saleAmount * 0.25;
    }
}