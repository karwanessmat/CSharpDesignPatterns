using Bridge1Demo.Abstraction;
using Bridge1Demo.Implementor;

namespace Bridge1Demo.RefinedAbstraction
{
   public class Circle(int radius, int x, int y, IDraw draw)
       : Shape(draw)
   {
        public int Radius { get; set; } = radius;
        public int X { get; set; } = x;
        public int Y { get; set; } = y;

        public override void Draw()
        {
            DrawApi.DrawCircle(Radius, X, Y);
        }
    }
}
