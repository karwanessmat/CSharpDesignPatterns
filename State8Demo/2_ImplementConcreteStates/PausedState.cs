using State8Demo._1_CreateStateInterface;

namespace State8Demo._2_ImplementConcreteStates;

public class PausedState : PlayerState
{
    public override void Play()
    {
        Console.WriteLine("Resuming video.");
        Player.TransitionTo(new PlayingState());
    }

    public override void Pause()
    {
        Console.WriteLine("Video is already paused.");
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping video.");
        Player.TransitionTo(new StoppedState());
    }
}