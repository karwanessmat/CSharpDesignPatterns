using AbstractFactory2Demo.Step1_AbstractProducts;
using AbstractFactory2Demo.Step3_Abstract_Factories;

namespace AbstractFactory2Demo.Step5_Client;

// Step 5: Client code that uses Abstract Factory to create furniture.
public class FurnitureStore(IFurnitureFactory furnitureFactory)
{
    public void ShowCaseFurniture()
    {
        IChair? chair = furnitureFactory.CreateChair();
        ISofa? sofa = furnitureFactory.CreateSofa();
        ICoffeeTable? coffeeTable = furnitureFactory.CreateCoffeeTable();

        chair.SitOn();
        sofa.RelaxOn();
        coffeeTable.Description();
    }
}