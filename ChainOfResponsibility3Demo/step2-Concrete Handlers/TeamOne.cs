using System;
using System.Threading;
using ChainOfResponsibility3Demo.Step1_Interface;

namespace ChainOfResponsibility3Demo.step2_Concrete_Handlers
{
   public class TeamOne(HandlerBase nextHandler, ContextObject question) : HandlerBase(nextHandler, question)
   {
       public override void HandleRequest()
        {
            Console.WriteLine("Question : {0}", Question.Question);
            Console.WriteLine("*******************************************");

            Console.WriteLine("Waiting for team one to respond");
            Thread.Sleep(4000);
            Console.WriteLine("\t no response from team one.....");

            NextTeam.HandleRequest();
        }
    }
}
