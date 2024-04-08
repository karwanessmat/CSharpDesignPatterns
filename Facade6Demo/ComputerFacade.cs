using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facade6Demo.Subsystem_Classes;

namespace Facade6Demo
{
    public class ComputerFacade: IComputerFacade
    {
        private readonly CPU _cpu = new();
        private readonly HardDrive hardDrive = new();
        private readonly Memory _memory = new();
        public void Start()
        {
            Console.WriteLine("Starting computer...");
            _cpu.Boot();
            _memory.Load(0, hardDrive.Read(0, 4096)); // Simplified example
            Console.WriteLine("Computer started successfully.");
        }

        public void ShutDown()
        {
            Console.WriteLine("Shutting down computer...");
            _cpu.ShutDown();
            Console.WriteLine("Computer shut down successfully.");
        }
    }
}
