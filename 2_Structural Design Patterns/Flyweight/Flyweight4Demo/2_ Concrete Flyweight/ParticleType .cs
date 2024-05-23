using Flyweight4Demo._1_Flyweight_Abastract_Interface;

namespace Flyweight4Demo._2__Concrete_Flyweight;

public class ParticleType(string color, string sprite): Flyweight

{
    public string Color { get; } = color;
    public string Sprite { get; } = sprite;


    public override void Draw(string coordinates, string victor, string speed)
    {
        // Draw the particle at the given coordinates with its sprite
        Console.WriteLine($"Drawing particle at {coordinates} with color {Color} and sprite {Sprite}");
    }
}