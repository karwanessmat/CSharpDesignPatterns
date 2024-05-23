using Proxy3Demo._1._Subject_Interface;
using Proxy3Demo._2.RealSubject;

namespace Proxy3Demo._3.Proxy;

/// <summary>
/// The 'Proxy Object' class
/// </summary>
internal class MathProxy : IMath
{
    private readonly Math _math = new();

    public double Add(double x, double y)
    {
        return _math.Add(x, y);
    }
    public double Sub(double x, double y)
    {
        return _math.Sub(x, y);
    }
    public double Mul(double x, double y)
    {
        return _math.Mul(x, y);
    }
    public double Div(double x, double y)
    {
        return _math.Div(x, y);
    }
}