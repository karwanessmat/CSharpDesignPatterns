using System;

namespace Observer3Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a Product with Out Of Stock Status
            var iphone = new ConcreteSubject.Subject("Iphone 1",250,"in Stock");

            var user1 = new ConcreteObserver.Observer("Karwan", iphone);
            var user2 = new ConcreteObserver.Observer("lewan", iphone);
            var user3 = new ConcreteObserver.Observer("baran", iphone);

            Console.WriteLine("Iphone 1 current State " +iphone.GetAvailability() );
            Console.WriteLine();

            // Now product is available
            iphone.SetAvailability("Available");
            Console.ReadLine();
        }
    }
}
