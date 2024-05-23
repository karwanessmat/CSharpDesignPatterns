using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

namespace Builder6Demo.Step3___Concrete_Builder;

public class LaptopBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void SetType() => _computer.Type = "Laptop";
    public void SetCpu() => _computer.Cpu = "Intel Core i5";
    public void SetRam() => _computer.Ram = "8GB";
    public void SetStorage() => _computer.Storage = "512GB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "Integrated Intel Iris Xe";

    public Computer Build() => _computer;
}
