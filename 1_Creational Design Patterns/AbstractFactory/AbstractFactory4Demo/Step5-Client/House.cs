using AbstractFactory4Demo.Step1_Abstract_Products;
using AbstractFactory4Demo.Step3_Abstract_Factories;

namespace AbstractFactory4Demo.Step5_Client;

// Client Code
public class House(IHouseFactory factory)
{
    private readonly IDoor _door = factory.CreateDoor();
    private readonly IWindow _window = factory.CreateWindow();

    public void DescribeHouse()
    {
        //var door = factory.CreateDoor();
        //var window = factory.CreateWindow();
        //door.Describe();
        //window.Describe();
        _door.Describe();
        _window.Describe();
    }
}