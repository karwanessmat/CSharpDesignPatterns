using Adapter6Demo;

var hole = new RoundHole(5);
var rpeg = new RoundPeg(5);
Console.WriteLine(hole.Fits(rpeg)); // true

var smallSqPeg = new SquarePeg(5);
var largeSqPeg = new SquarePeg(10);
//Console.WriteLine(hole.Fits(smallSqPeg)); // Won't compile, incompatible types.

var smallSqPegAdapter = new SquarePegAdapter(smallSqPeg);
var largeSqPegAdapter = new SquarePegAdapter(largeSqPeg);
Console.WriteLine(hole.Fits(smallSqPegAdapter)); // true
Console.WriteLine(hole.Fits(largeSqPegAdapter)); // false