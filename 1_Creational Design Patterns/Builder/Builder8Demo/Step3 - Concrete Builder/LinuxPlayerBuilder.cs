
using Builder8Demo.Step1_Production;
using Builder8Demo.Step2___Builder_Interface;

namespace Builder8Demo.Step3___Concrete_Builder;

internal class LinuxPlayerBuilder:IPlayerBuilder
{
    private readonly Player _player = new();
    public void AddPlayButton()
    {
        _player.PlayButton = new LinuxPlayButton();
    }

    public void AddStopButton()
    {
        _player.StopButton = new LinuxStopButton();
    }

    public Player BuildPlayer()
    {
        return _player;
    }
}