using System;
using ChainOfResponsibility3Demo.step2_Concrete_Handlers;

namespace ChainOfResponsibility3Demo
{
    class Program
    {
        static void Main(string[] args)
        {


            var question = 
                new ContextObject()
                {
                    Question = "Who is an edit in your team?"
                };

            TeamThree teamThree = new TeamThree(null, question);
            TeamTwo teamTwo = new TeamTwo(teamThree, question);
            TeamOne teamOne = new TeamOne(teamTwo, question);

            teamOne.HandleRequest();
            Console.ReadKey();



        }
    }
}
