using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade6Demo.Subsystem_Classes;

public class CPU
{
   public void Boot()
    {
        Console.WriteLine("Cpu booting up");
    }

    public void ShutDown()
    {
        Console.WriteLine("Cpu shutting down");
    }
}