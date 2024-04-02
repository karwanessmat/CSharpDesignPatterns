using AbstractFactory2Demo.Step3_Abstract_Factories;

namespace AbstractFactory2Demo.Step5_Client
{
    // Step 5: Client code that uses Abstract Factory to create furniture.
    public class FurnitureStore(IFurnitureFactory furnitureFactory)
    {
        public void ShowCaseFurniture()
        {
            var chair = furnitureFactory.CreateChair();
            var sofa = furnitureFactory.CreateSofa();
            var coffeeTable = furnitureFactory.CreateCoffeeTable();
            chair.SitOn();
            sofa.RelaxOn();
            coffeeTable.Description();
        }
    }
}
