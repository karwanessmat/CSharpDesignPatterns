using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flyweight4Demo._1.ConcreteFlyweight;
using Flyweight4Demo._2.Flyweight_Abstract;

namespace Flyweight4Demo._5.Context;


/// <summary>
/// This class will represent the context in which the flyweights operate, containing extrinsic states.
/// </summary>
/// <param name="particleType"></param>
/// <param name="coordinates"></param>
/// <param name="vector"></param>
/// <param name="speed"></param>
public class Particle(Flyweight particleType, string coordinates, string vector, string speed)
{
    public string Coordinates { get; } = coordinates;
    public string Vector { get; } = vector;
    public string Speed { get; } = speed;

    public void Draw()
    {
        particleType.Draw(Coordinates, Vector, Speed);
    }
}