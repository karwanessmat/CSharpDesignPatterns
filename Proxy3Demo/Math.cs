using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy3Demo
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
