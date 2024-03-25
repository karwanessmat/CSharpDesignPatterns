using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command2Demo
{
    public interface IOrder
    {
        void Execute(int value);
    }
}
