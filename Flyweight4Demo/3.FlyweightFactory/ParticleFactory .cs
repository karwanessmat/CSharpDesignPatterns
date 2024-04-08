using Flyweight4Demo._1.ConcreteFlyweight;

namespace Flyweight4Demo._3.FlyweightFactory;
public class ParticleFactory
{
    private readonly Dictionary<string, ParticleType> _particles = new();

    public ParticleType GetParticleType(string color, string sprite)
    {
        var key = $"{color}_{sprite}";
        if (_particles.TryGetValue(key, out var particleType)) 
            return particleType;

        particleType = new ParticleType(color, sprite);
        _particles[key] = particleType;
        return particleType;
    }
}

