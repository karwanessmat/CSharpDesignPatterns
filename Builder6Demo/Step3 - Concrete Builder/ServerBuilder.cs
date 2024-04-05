using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

namespace Builder6Demo.Step3___Concrete_Builder;

public class ServerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetType() => _computer.Type = "Server";
    public void SetCPU() => _computer.CPU = "AMD EPYC 7742";
    public void SetRAM() => _computer.RAM = "64GB";
    public void SetStorage() => _computer.Storage = "4TB SSD";
    public void SetGraphicsCard() => _computer.GraphicsCard = "NVIDIA Tesla";

    public Computer Build() => _computer;
}