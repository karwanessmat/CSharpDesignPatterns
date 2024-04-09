using Proxy3Demo._1._Subject_Interface;

namespace Proxy3Demo._2.RealSubject
{
    /// <summary>
    /// The 'RealSubject' class
    /// </summary>
    internal class Math : IMath
    {
        public double Add(double x, double y) { return x + y; }
        public double Sub(double x, double y) { return x - y; }
        public double Mul(double x, double y) { return x * y; }
        public double Div(double x, double y) { return x / y; }
    }
}
