namespace Adapter6Demo;

public class RoundHole(double radius)
{
    public double GetRadius()
    {
        return radius;
    }

    public bool Fits(RoundPeg peg)
    {
        return GetRadius() >= peg.GetRadius();
    }
}

// Adapter class