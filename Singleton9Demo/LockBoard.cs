using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton9Demo
{
    public sealed class LockBoard
    {
        private static LockBoard _instance;
        private static readonly object _lock = new object();
        public string BoardName { get; set; }

        private LockBoard() { }
        public static LockBoard GetInstance(string boardName)
        {
            if (_instance is null)
            {
                lock (_lock)
                {
                    if (_instance is null)
                    {
                        Console.WriteLine($"Connection to {boardName} created");
                        _instance = new LockBoard();
                        _instance.BoardName = boardName;
                    }
                }
            }

            return _instance;
        }

        public void Execute(string programName)
        {
            Console.WriteLine($"Executing Program {programName} on {BoardName}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i.ToString());
            }
        }
    }
}
