using Builder8Demo.Step1_Production;
using Builder8Demo.Step2___Builder_Interface;

namespace Builder8Demo.Step4___Directors
{
    public class PlayerDirector
    {
        public Player BuildPlayer(IPlayerBuilder builder)
        {

            builder.AddPlayButton();
            builder.AddStopButton();
            return builder.BuildPlayer();
        }
    }
}
