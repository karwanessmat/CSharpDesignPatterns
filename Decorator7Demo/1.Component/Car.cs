using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Decorator7Demo._1.Component
{
    public abstract class Car
    {
        public string Description { get; set; }
        public abstract string GetDescription();
        public abstract double GetCarPrice();
    }
}
