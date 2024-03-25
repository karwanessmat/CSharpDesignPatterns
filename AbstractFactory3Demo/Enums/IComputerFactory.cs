using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory3Demo.AbstractProduct;

namespace AbstractFactory3Demo.Enums
{
    internal interface IComputerFactory
    {
        IBrand Brand();
        IComputerTypes ComputerTypes();
        IProcessor Processor();
    }
}
