using AbstractFactory2Demo.Step4_Concrete_Factories;
using AbstractFactory2Demo.Step5_Client;


var store = new FurnitureStore(new ModernFurnitureFactory());
store.ShowCaseFurniture();