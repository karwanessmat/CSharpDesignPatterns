using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

namespace Builder6Demo.Step3___Concrete_Builder;

public class DesktopBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void SetType() => _computer.Type = "Desktop";
    public void SetCpu() => _computer.Cpu = "Intel Core i7";
    public void SetRam() => _computer.Ram = "16GB";
    public void SetStorage() => _computer.Storage = "1TB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "NVIDIA RTX 3080";

    public Computer Build() => _computer;
}
