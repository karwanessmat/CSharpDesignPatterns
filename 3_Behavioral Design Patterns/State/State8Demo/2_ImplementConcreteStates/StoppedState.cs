using State8Demo._1_CreateStateInterface;

namespace State8Demo._2_ImplementConcreteStates;

// the current state is Stopped
public class StoppedState : PlayerState
{
    public override void Play()
    {
        Console.WriteLine("Starting video.");
        Player.TransitionTo(new PlayingState());
    }

    public override void Pause()
    {
        Console.WriteLine("Video is stopped, cannot pause.");
    }

    public override void Stop()
    {
        Console.WriteLine("Video is already stopped.");
    }
}