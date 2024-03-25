using Bridge1Demo.Abstraction;
using Bridge1Demo.Implementor;

namespace Bridge1Demo.ConcreteImplementation
{
   public class Circle :Shape
    {
        public int Radius { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Circle( int radius, int x,int y, IDraw draw) : base(draw)
        {
            Radius = radius;
            X = x;
            Y = y;
        }

        public override void Draw()
        {
            drawapi.DrawCircle(Radius, X, Y);
        }
    }
}
