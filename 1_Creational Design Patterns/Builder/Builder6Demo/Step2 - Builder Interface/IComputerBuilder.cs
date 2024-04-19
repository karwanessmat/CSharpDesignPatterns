using Builder6Demo.Step1_Production;

namespace Builder6Demo.Step2___Builder_Interface;

public interface IComputerBuilder
{
    void SetType();
    void SetCPU();
    void SetRAM();
    void SetStorage();
    void SetGraphicsCard();
    Computer Build();
}