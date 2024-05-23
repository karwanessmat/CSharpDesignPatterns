using System;
using System.Collections.Generic;
using Observer2Demo.Step1_Define_Observer_Interface;

namespace Observer2Demo.Step2_Define_Subject_Interface;

/// <summary>
/// the Subject abstract class
/// </summary>
public abstract class Stock
{
    private readonly List<IInvestor> _investors = [];
    public string Symbol { get; }

    private double _price;
    public double Price
    {
        get => _price;
        set
        {
            if (_price == value) 
                return;
                
                
            _price = value;
            Notify();
        }
    }

    protected Stock(string symbol, double price)
    {
        Symbol = symbol;
        Price = price;
    }

    public void Attach(IInvestor investor)
    {
        _investors.Add(investor);
    }

    public void Detach(IInvestor investor)
    {
        _investors.Remove(investor);
    }

    public void Notify()
    {
        foreach (var investor in _investors)
        {
            investor.Update(this);
        }
        Console.WriteLine("");

    }



}