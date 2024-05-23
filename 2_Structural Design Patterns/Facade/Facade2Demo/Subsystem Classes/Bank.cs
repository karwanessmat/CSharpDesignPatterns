using System;

namespace Facade2Demo.Subsystem_Classes;

/// <summary>
/// The 'Subsystem ClassA' class
/// </summary>
public class Bank

{
    public bool HasSufficientSavings(Customer c, int amount)
    {
        Console.WriteLine("Check bank for " + c.Name);
        return amount>2500;
    }
}