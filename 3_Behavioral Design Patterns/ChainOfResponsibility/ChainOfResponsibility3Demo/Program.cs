using System;
using ChainOfResponsibility3Demo.step2_Concrete_Handlers;

namespace ChainOfResponsibility3Demo;

class Program
{
    static void Main(string[] args)
    {


        var question = 
            new ContextObject()
            {
                Question = "Who is an edit in your team?"
            };

        var teamThree = new TeamThree(null, question);
        var teamTwo = new TeamTwo(teamThree, question);
        var teamOne = new TeamOne(teamTwo, question);

        teamOne.HandleRequest();
        Console.ReadKey();



    }
}