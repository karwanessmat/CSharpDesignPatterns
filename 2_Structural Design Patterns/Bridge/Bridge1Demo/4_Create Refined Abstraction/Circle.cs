using Bridge1Demo._1_Define_Implementor_Interface;
using Bridge1Demo._3_Define_Abstraction;

namespace Bridge1Demo._4_Create_Refined_Abstraction;

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