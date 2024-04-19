using Builder8Demo.Helper;

namespace Builder8Demo.Step1_Production;

internal class LinuxStopButton : StopButton
{
    public override Task Stop(string fileName)
    {
        if (LinuxPlayerUtility.PlaybackProcess != null)
        {
            LinuxPlayerUtility.PlaybackProcess.Kill();
            LinuxPlayerUtility.PlaybackProcess.Dispose();
            LinuxPlayerUtility.PlaybackProcess = null;
        }

        return Task.CompletedTask;
    }
}