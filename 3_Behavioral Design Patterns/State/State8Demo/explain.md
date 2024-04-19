
# Video Player State Management System

This project demonstrates the use of the State design pattern to manage the states of a video player. The player can be in one of three states: Playing, Paused, or Stopped. Each state has specific behaviors and transitions that are encapsulated within state classes.

## Implementation Details

### 1. Abstract State Class 🎥

The abstract `PlayerState` class defines a common interface for all concrete state classes. It ensures that all states can interact with the `VideoPlayerContext` and defines the mandatory methods that all states must implement.

**Code:**
```csharp
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
```

### 2. Concrete State Classes 🚥

Each state of the video player is represented by a concrete state class. These classes implement the behaviors associated with specific actions in each state.

#### Playing State
Handles behavior and transitions when the video is playing.

**Code:**
```csharp
public class PlayingState : PlayerState
{
    public override void Play()
    {
        Console.WriteLine("Video is already playing.");
    }

    public override void Pause()
    {
        Console.WriteLine("Pausing video.");
        Player.TransitionTo(new PausedState());
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping video.");
        Player.TransitionTo(new StoppedState());
    }
}
```

#### Paused State
Allows the video to be played or stopped from the paused state.

**Code:**
```csharp
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
```

#### Stopped State
Only allows the video to be played from the stopped state.

**Code:**
```csharp
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
```

### 3. Context Class 🌐

The `VideoPlayerContext` class maintains the current state of the player and allows for transitions between states. It acts as the primary interface for client interaction.

**Code:**
```csharp
public class VideoPlayerContext
{
    private PlayerState _state;

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
```

### 4. Usage Example 🚀

Demonstrates how to use the context and states to control the video player through its lifecycle stages.

**Code:**
```csharp
public class Program
{
    public static void Main(string[] args)
    {
        var player = new VideoPlayerContext(new StoppedState());
        player.Play();    // Starts the video
        player.Pause();   // Pauses the video
        player.Play();    // Resumes the video
        player.Stop();    // Stops the video
    }
}
```

## Conclusion

This system illustrates how the State design pattern can effectively manage state transitions in complex systems like a video player, ensuring that operations are valid for the current state and simplifying the management of state-dependent behaviors.
```

This README provides a comprehensive overview, along with snippets of code for each part of the implementation, explaining the use of the State design pattern in managing the states of a video player.