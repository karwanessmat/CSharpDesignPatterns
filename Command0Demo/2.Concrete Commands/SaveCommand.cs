using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Command0Demo._1.Command_Interface;

namespace Command0Demo._2.Concrete_Commands;

internal class SaveCommand : ICommand
{
    public void Execute()
    {
        // logic
        Console.WriteLine("Save command");
    }
}