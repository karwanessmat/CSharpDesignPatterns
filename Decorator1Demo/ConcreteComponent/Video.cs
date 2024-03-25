using System;
using Decorator1Demo.Component;

namespace Decorator1Demo.ConcreteComponent
{
    /// <summary>
    /// The 'ConcreteComponent' class
    /// </summary>
    public class Video:LibraryItem
    {
        public string Director { get; set; }
        public string Title { get; set; }
        public int PlayTime { get; set; }
        public Video(string director, string title, int playTime, int numCopies)
        {
            Director = director;
            Title = title;
            PlayTime = playTime;
            NumCopies = numCopies;
        }

        
        public override void Display()
        {
            Console.WriteLine("\nVideos");
            Console.WriteLine($"Director {Director}");
            Console.WriteLine($"Title {Title}");
            Console.WriteLine($"Play Time {PlayTime}");
            Console.WriteLine($"# Copies {NumCopies}");
        }
    }
}
