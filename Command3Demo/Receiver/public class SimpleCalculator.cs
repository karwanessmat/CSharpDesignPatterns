using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command3Demo.Receiver
{
    public class SimpleCalculator
    {
        private readonly int _x;
        private readonly int _y;

        public SimpleCalculator(int a, int b)
        {
            _x = a;
            _y = b;
        }
        public int Add()
        {
            return _x + _y;
        }
        public int Subtract()
        {
            return _x - _y;
        }
        public int Multiply()
        {
            return _x * _y;
        }
        public int Divide()
        {
            return _x / _y;
        }
    }
}
