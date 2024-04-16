using State8Demo._3_ContextClass;

namespace State8Demo._1_CreateStateInterface;

public abstract class PlayerState
{
    protected VideoPlayerContext Player;

    public void SetContext(VideoPlayerContext player)
    {
        this.Player = player;
    }

    public abstract void Play();
    public abstract void Pause();
    public abstract void Stop();
}