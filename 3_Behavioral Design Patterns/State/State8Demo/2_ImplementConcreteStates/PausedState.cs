using State8Demo._1_CreateStateInterface;

namespace State8Demo._2_ImplementConcreteStates;

// the current state is Paused
public class PausedState : PlayerState
{

    /// <summary>
    /// the video is paused, now if we click Play button, then the state is changed to PlayingState
    /// </summary>
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