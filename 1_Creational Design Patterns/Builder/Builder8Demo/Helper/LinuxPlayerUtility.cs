using System.Diagnostics;

namespace Builder8Demo.Helper;


internal static class LinuxPlayerUtility
{
    public static Process? PlaybackProcess { get; set; }

    public static void StartBashProcess(string command)
    {
        string? escapedArgs = command.Replace("\"", "\\\"");

        var process = new Process()
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = "/bin/bash",
                Arguments = $"-c \"{escapedArgs}\"",
                RedirectStandardOutput = true,
                RedirectStandardInput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
            }
        };

        process.Start();
    }
}