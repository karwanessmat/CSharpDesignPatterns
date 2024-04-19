using Builder8Demo.Step1_Production;

namespace Builder8Demo.Step2___Builder_Interface;

public interface IPlayerBuilder
{
    void AddPlayButton();
    void AddStopButton();
    Player BuildPlayer();
}