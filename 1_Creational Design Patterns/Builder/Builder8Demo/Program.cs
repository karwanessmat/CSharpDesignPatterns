﻿using System.Runtime.InteropServices;
using Builder8Demo.Step1_Production;
using Builder8Demo.Step3___Concrete_Builder;
using Builder8Demo.Step4___Directors;

var director = new PlayerDirector();
Player? player;

if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
{
    player = director.BuildPlayer(new WindowsPlayerBuilder());
}
else
{
    player = RuntimeInformation.IsOSPlatform(OSPlatform.Linux)
        ? director.BuildPlayer(new LinuxPlayerBuilder())
        : throw new Exception("Only Linux and Windows operating systems are supported.");
}

Console.WriteLine("Please specify the path to the file to play.");

string? filePath = Console.ReadLine() ?? string.Empty;
player.PlayButton?.Play(filePath);

Console.WriteLine("Playing audio. Type 'stop' to stop it or 'exit' to exit the application.");

while (true)
{
    string? command = Console.ReadLine();

    if (command == "stop")
    {
        player.StopButton?.Stop(filePath);
    }
    else if (command == "exit")
    {
        break;
    }
}

Console.ReadKey();
