using AbstractFactory2Demo.Step3_Abstract_Factories;
using AbstractFactory2Demo.Step4_Concrete_Factories;
using AbstractFactory2Demo.Step5_Client;

IFurnitureFactory furnitureFactory = new ModernFurnitureFactory();
var store = new FurnitureStore(furnitureFactory);
store.ShowCaseFurniture();