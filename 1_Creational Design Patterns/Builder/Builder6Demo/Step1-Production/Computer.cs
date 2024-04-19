namespace Builder6Demo.Step1_Production;

public class Computer
{
    public string Type { get; set; }
    public string CPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }
    public string GraphicsCard { get; set; }

    public override string ToString()
    {
        return $"{Type}: CPU={CPU}, RAM={RAM}, Storage={Storage}, GraphicsCard={GraphicsCard}";
    }
}