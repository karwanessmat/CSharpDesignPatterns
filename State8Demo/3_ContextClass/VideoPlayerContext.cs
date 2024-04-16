using State8Demo._1_CreateStateInterface;

namespace State8Demo._3_ContextClass;
public class VideoPlayerContext
{
    private PlayerState _state = null!;

    public VideoPlayerContext(PlayerState state)
    {
        TransitionTo(state);
    }

    public void TransitionTo(PlayerState state)
    {
        Console.WriteLine($"Transitioning to {state.GetType().Name}");
        this._state = state;
        this._state.SetContext(this);
    }

    public void Play()
    {
        this._state.Play();
    }

    public void Pause()
    {
        this._state.Pause();
    }

    public void Stop()
    {
        this._state.Stop();
    }
}