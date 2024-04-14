using State3Demo._1_CreateStateInterface;
using State3Demo._3_ContextClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State3Demo._2_ImplementConcreteStates;

public class NoCardState(AtmMachine newAtmMachine) : IAtmState
{
    public void InsertCard()
    {
        newAtmMachine.SetHasCardState();
    }

    public void EjectCard()
    {
        Console.WriteLine("You haven't inserted a card");
    }

    public void InsertPin(int pin)
    {
        Console.WriteLine("You haven't inserted a card");
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("You haven't inserted a card");
    }
}