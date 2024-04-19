using State8Demo._2_ImplementConcreteStates;
using State8Demo._3_ContextClass;

var player = new VideoPlayerContext(new StoppedState());
player.Play();    // Starts the video
player.Pause();   // Pauses the video
player.Play();    // Resumes the video
player.Stop();    // Stops the video