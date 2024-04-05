using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

public class ComputerDirector
{
    public Computer Construct(IComputerBuilder builder)
    {
        builder.SetType();
        builder.SetCPU();
        builder.SetRAM();
        builder.SetStorage();
        builder.SetGraphicsCard();
        return builder.Build();
    }
}