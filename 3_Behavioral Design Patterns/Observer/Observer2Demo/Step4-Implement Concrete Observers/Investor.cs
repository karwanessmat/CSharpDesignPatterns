using System;
using Observer2Demo.Step1_Define_Observer_Interface;
using Observer2Demo.Step2_Define_Subject_Interface;

namespace Observer2Demo.Step4_Implement_Concrete_Observers;

/// <summary>
/// The 'ConcreteObserver' class
/// </summary>
public class Investor(string name) : IInvestor
{
    public void Update(Stock stock)
    {
        Console.WriteLine($"Notified {name} of {stock.Symbol} change to {stock.Price:c}");
    }
}