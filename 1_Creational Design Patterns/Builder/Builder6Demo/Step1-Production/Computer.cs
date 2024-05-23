namespace Builder6Demo.Step1_Production;

public class Computer
{
    public string Type { get; set; }
    public string Cpu { get; set; }
    public string Ram { get; set; }
    public string Storage { get; set; }
    public string GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"{Type}: CPU={Cpu}, RAM={Ram}, Storage={Storage}, GraphicsCard={GraphicsCard}";
    }
}
