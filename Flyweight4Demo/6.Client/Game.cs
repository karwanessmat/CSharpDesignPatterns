using Flyweight4Demo._3.FlyweightFactory;
using Flyweight4Demo._5.Context;

namespace Flyweight4Demo._6.Client;

/// <summary>
/// The Game class serves as the client, using the flyweight factory to create and manage particles.
/// </summary>
public class Game
{
    private readonly ParticleFactory _particleFactory = new();
    private readonly List<Particle> _particles = [];

    public void AddParticle(string color, string sprite, string coordinates, string vector, string speed)
    {
        var particleType = _particleFactory.GetParticleType(color, sprite);
        if (particleType == null) return;
        var particle = new Particle(particleType, coordinates, vector, speed);
        _particles.Add(particle);
    }

    public void Draw()
    {
        foreach (var particle in _particles)
        {
            particle.Draw();
        }
    }
}
