using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter9Demo;

// Incompatible Plug (Adaptee)
public class EuropeanPlug
{
    public string GetElectricity()
    {
        return "Getting 220V from European Plug";
    }
}

// Incompatible Socket (Client's expectation)