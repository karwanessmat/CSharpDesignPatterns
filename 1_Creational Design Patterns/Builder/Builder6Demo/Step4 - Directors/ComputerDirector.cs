using Builder6Demo.Step1_Production;
using Builder6Demo.Step2___Builder_Interface;

namespace Builder6Demo.Step4___Directors;

public class ComputerDirector
{
    public Computer Construct(IComputerBuilder builder)
    {
        builder.SetType();
        builder.SetCpu();
        builder.SetRam();
        builder.SetStorage();
        builder.SetGraphicsCard();
        return builder.Build();
    }
}
