using System;
using Observer3Demo.Step3_Implement_Concrete_Subject;
using Observer3Demo.Step4_Implement_Concrete_Observers;

namespace Observer3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            var iphone = new Subject("Iphone 1",250,"in Stock");

            
            var user1 = new Observer("Karwan", iphone);
            var user2 = new Observer("lewan", iphone);
            var user3 = new Observer("baran", iphone);

            Console.WriteLine("Iphone 1 current State " +iphone.GetAvailability() );
            Console.WriteLine();

            // Now product is available
            iphone.SetAvailability("AvailableXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
            Console.ReadLine();
        }
    }
}
