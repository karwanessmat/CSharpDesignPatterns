using System;
using Decorator1Demo.ConcreteComponent;
using Decorator1Demo.ConcreteDecorator;

namespace Decorator1Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            //create book
            var book = new Book("Karwan","Excel In use",500);
            book.Display();


            //create video
            var video =new Video("Kurdish man","Bekas",95,20);
            video.Display();

            // make video borrowable, then borrow and display
            Console.WriteLine("\n Making video borrowable:");
            Borrowable borrowVideo = new Borrowable(video);
            borrowVideo.BorrowItem("Customer #1");
            borrowVideo.BorrowItem("Customer #2");

            borrowVideo.Display();

            // Wait for user
            Console.ReadLine();
        }
    }
}
