using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

public class LaptopBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetType() => _computer.Type = "Laptop";
    public void SetCPU() => _computer.CPU = "Intel Core i5";
    public void SetRAM() => _computer.RAM = "8GB";
    public void SetStorage() => _computer.Storage = "512GB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "Integrated Intel Iris Xe";

    public Computer Build() => _computer;
}