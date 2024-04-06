namespace Adapter6Demo;

public class SquarePegAdapter(SquarePeg peg) : RoundPeg(peg.GetWidth() * Math.Sqrt(2) / 2)
{
    private SquarePeg _peg = peg;

    // This calculates the radius of the smallest circle that can fit the square peg.

    // The GetRadius method is inherited from the RoundPeg class.
}