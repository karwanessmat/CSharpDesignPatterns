using Builder8Demo.Helper;

namespace Builder8Demo.Step1_Production;
    internal class LinuxPlayButton: PlayButton
    {
        public override Task Play(string fileName)
        {
            LinuxPlayerUtility.StartBashProcess($"mpg123 -q '{fileName}'");
            return Task.CompletedTask;
        }
    }