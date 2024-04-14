using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using State8Demo._1_CreateStateInterface;

namespace State8Demo._2_ImplementConcreteStates;


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