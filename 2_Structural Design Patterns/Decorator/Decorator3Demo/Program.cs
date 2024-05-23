using System;
using Decorator3Demo._2_Create_a_Concrete_Component;
using Decorator3Demo._4_Create_Concrete_Decorator;

namespace Decorator3Demo;

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
        var borrowVideo = new Borrowable(video);
        borrowVideo.BorrowItem("Customer #1");
        borrowVideo.BorrowItem("Customer #2");

        borrowVideo.Display();

        // Wait for user
        Console.ReadLine();
    }
}