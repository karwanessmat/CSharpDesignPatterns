using State3Demo._1_CreateStateInterface;
using State3Demo._3_ContextClass;

namespace State3Demo._2_ImplementConcreteStates;

public class CorrectPinState(AtmMachine newAtmMachine) : IAtmState
{
    public void InsertCard()
    {
        Console.WriteLine("You already entered the correct PIN");
    }

    public void EjectCard()
    {
        Console.WriteLine("Your card is ejected");
        newAtmMachine.SetNoCardState();
    }

    public void InsertPin(int pin)
    {
        Console.WriteLine("You already entered the correct PIN");
    }

    public void RequestCash(int cashToWithdraw)
    {
        if (cashToWithdraw <= newAtmMachine.CashInMachine)
        {
            Console.WriteLine(cashToWithdraw + " is provided by the machine");
            newAtmMachine.CashInMachine -= cashToWithdraw;

            if (newAtmMachine.CashInMachine > 0)
            {
                Console.WriteLine("You still have " + newAtmMachine.CashInMachine + " left in the machine");
            }
            else
            {
                Console.WriteLine("Machine is out of money");
            }
        }
        else
        {
            Console.WriteLine("You don't have enough money in your account");
        }
    }
}