using System;
using ChainOfResponsibility4Demo.Step1_Interface;
using ChainOfResponsibility4Demo.step2_Concrete_Handlers;

namespace ChainOfResponsibility4Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility
            Approver tammy = new President(null);
            Approver sam = new VicePresident(tammy);
            Approver larry = new Director(sam);


            // Generate and process purchase requests
            var purchase = new Purchase(2034, 5000, "Assets");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2035, 15000, "Project X");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 25000, "Project Y");
            larry.ProcessRequest(purchase);

            purchase = new Purchase(2036, 55000, "Project Y");
            larry.ProcessRequest(purchase);

            // Wait for user

            Console.ReadKey();
        }
    }
}
