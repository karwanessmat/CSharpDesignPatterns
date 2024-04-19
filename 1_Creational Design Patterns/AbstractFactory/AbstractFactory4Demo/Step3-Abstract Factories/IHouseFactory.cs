using AbstractFactory4Demo.Step1_Abstract_Products;

namespace AbstractFactory4Demo.Step3_Abstract_Factories
{
    public interface IHouseFactory
    {
        IDoor CreateDoor();
        IWindow CreateWindow();
    }
}
