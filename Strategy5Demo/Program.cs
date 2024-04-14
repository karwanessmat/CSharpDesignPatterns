// Sale amount example

using Strategy5Demo._2_Concrete_Strategies;
using Strategy5Demo._3_ContextClass;

double saleAmount = 100.0;

// Applying seasonal discount
DiscountContext discountContext = new DiscountContext(new SeasonalDiscountStrategy());
Console.WriteLine($"Final price with seasonal discount: ${discountContext.ApplyDiscount(saleAmount)}");

// Switching to promotional discount
discountContext.SetDiscountStrategy(new PromotionalDiscountStrategy());
Console.WriteLine($"Final price with promotional discount: ${discountContext.ApplyDiscount(saleAmount)}");

// Switching to loyalty discount
discountContext.SetDiscountStrategy(new LoyaltyDiscountStrategy());
Console.WriteLine($"Final price with loyalty discount: ${discountContext.ApplyDiscount(saleAmount)}");
