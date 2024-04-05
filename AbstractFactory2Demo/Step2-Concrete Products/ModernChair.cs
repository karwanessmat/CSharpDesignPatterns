using AbstractFactory2Demo.Step1_AbstractProducts;

namespace AbstractFactory2Demo.Step2_Concrete_Products
{
    // Step 2: Create Concrete Products - Modern and Victorian variants of the furniture.
    public class ModernChair : IChair
    {
        public void SitOn()
        {
            Console.WriteLine("Sitting on a modern chair.");
        }
    }
}
