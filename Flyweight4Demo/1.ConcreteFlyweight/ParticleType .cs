using Flyweight4Demo._2.Flyweight_Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight4Demo._1.ConcreteFlyweight
{
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
}
