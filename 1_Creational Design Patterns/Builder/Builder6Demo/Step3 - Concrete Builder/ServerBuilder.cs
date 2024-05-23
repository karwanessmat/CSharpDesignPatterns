using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

namespace Builder6Demo.Step3___Concrete_Builder;

public class ServerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void SetType() => _computer.Type = "Server";
    public void SetCpu() => _computer.Cpu = "AMD EPYC 7742";
    public void SetRam() => _computer.Ram = "64GB";
    public void SetStorage() => _computer.Storage = "4TB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "NVIDIA Tesla";

    public Computer Build() => _computer;
}
