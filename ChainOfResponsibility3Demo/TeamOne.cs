using System;
using System.Threading;

namespace ChainOfResponsibility3Demo
{
   public class TeamOne(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
   {
       public override void HandleRequest()
        {
            Console.WriteLine("Question : {0}", Question.Question);
            Console.WriteLine("*******************************************");

            Console.WriteLine("Waiting for team one to respond");
            Thread.Sleep(10000);
            Console.WriteLine("\t no response from team one.....");

            NextTeam.HandleRequest();
        }
    }

   public class TeamTwo(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
   {
       public override void HandleRequest()
       {
           Console.WriteLine("Wating for team two to respond");

           Thread.Sleep(10000);

           Console.WriteLine("\t no response from team two.....");
           NextTeam.HandleRequest();
       }
   }

   public class TeamThree(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
   {
       public override void HandleRequest()
       {
           Console.WriteLine("Waiting for team three to respond");
           Thread.Sleep(10000);
           Console.WriteLine("\t no response from team three as well .....");
       }
   }
}
