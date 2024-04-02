using System.Runtime.InteropServices;
using Factory3Demo.Step3_Creator;
using Factory3Demo.step4_ConcreteCreator;

PlayerCreator? playerFactory;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
    playerFactory = new WindowsPlayerCreator();
else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
    playerFactory = new LinuxPlayerCreator();
else
    throw new Exception("Only Linux and Windows operating systems are supported.");

Console.WriteLine("Please specify the path to the file to play");

var filePath = Console.ReadLine() ?? string.Empty;
playerFactory.CreatePlayer().Play(filePath);

Console.ReadKey();