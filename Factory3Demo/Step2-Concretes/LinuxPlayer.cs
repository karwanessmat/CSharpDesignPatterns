using System.Diagnostics;
using Factory3Demo.Step1_Product;

namespace Factory3Demo.Step2_Concretes
{
    public class LinuxPlayer:Player
    {
        public override Task Play(string fileName)
        {
            StartBashProcess($"mpg123 -q '{fileName}'");
            return Task.CompletedTask;
        }

        private void StartBashProcess(string command)
        {
            var escapedArgs = command.Replace("\"", "\\\"");

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
}
