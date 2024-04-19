using Builder8Demo.Helper;

namespace Builder8Demo.Step1_Production;

internal class WindowsPlayButton : PlayButton
{
    public override Task Play(string fileName)
    {
        WindowsPlayerUtility.ExecuteMciCommand($"Play {fileName}");
        return Task.CompletedTask;
    }
}