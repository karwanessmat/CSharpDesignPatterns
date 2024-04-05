using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

public class DesktopBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetType() => _computer.Type = "Desktop";
    public void SetCPU() => _computer.CPU = "Intel Core i7";
    public void SetRAM() => _computer.RAM = "16GB";
    public void SetStorage() => _computer.Storage = "1TB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "NVIDIA RTX 3080";

    public Computer Build() => _computer;
}