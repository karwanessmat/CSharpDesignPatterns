using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton9Demo;

public sealed class Board
{
    private static Board _instance;
    public string BoardName { get; set; }


    private Board()
    {

    }


    public static Board GetInstance(string boardName)
    {
        if (_instance is null)
        {
            _instance = new Board();
            _instance.BoardName = boardName;
            Console.WriteLine($"Connection to {boardName} created");
        }

        return _instance;
    }

    public void Execute(string programName)
    {
        Console.WriteLine($"Executing Program {programName} on {BoardName}");
        
        for (var i = 0; i < 10; i++)
        {
            Console.WriteLine(i.ToString());
        }
    }
}