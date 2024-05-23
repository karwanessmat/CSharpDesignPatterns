using System;

namespace ChainOfResponsibility2Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        // The other part of the client code constructs the actual chain.
        var monkey = new MonkeyHandler();
        var squirrel = new SquirrelHandler();
        var dog = new DogHandler();

        monkey.SetNext(squirrel).SetNext(dog);

        // The client should be able to send a request to any handler, not
        // just the first one in the chain.
        Console.WriteLine("Chain: Monkey > Squirrel > Dog");
        Client.ClientCode(monkey);
        Console.WriteLine("_______________________");

        Console.WriteLine("Sub chain: Squirrel > Dog");
        Client.ClientCode(squirrel);
        Console.WriteLine("_______________________");

        Console.WriteLine("Sub chain: Dog > Squirrel");
        Client.ClientCode(dog);
        Console.WriteLine("_______________________");


        Console.ReadLine();
    }
}