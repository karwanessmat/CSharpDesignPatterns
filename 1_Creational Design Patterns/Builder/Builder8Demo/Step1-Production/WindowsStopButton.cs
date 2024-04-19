using Builder8Demo.Helper;

namespace Builder8Demo.Step1_Production;

internal class WindowsStopButton : StopButton
{
    public override Task Stop(string fileName)
    {
        WindowsPlayerUtility.ExecuteMciCommand($"Stop {fileName}");
        return Task.CompletedTask;
    }
}