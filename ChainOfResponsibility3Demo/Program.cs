using System;

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
