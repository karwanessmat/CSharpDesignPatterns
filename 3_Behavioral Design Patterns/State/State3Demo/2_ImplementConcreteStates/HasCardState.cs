using State3Demo._1_CreateStateInterface;
using State3Demo._3_ContextClass;

namespace State3Demo._2_ImplementConcreteStates;

public class HasCardState : IAtmState
{
    private readonly AtmMachine _atmMachine;

    public HasCardState(AtmMachine newAtmMachine)
    {
        _atmMachine = newAtmMachine;
    }

    public void InsertCard()
    {
        Console.WriteLine("You already inserted a card");
    }

    public void EjectCard()
    {
        Console.WriteLine("Your card is ejected");
        _atmMachine.SetNoCardState();
    }

    public void InsertPin(int pin)
    {
        if (pin == 1234)
        {
            Console.WriteLine("You entered the correct PIN");
            _atmMachine.SetCorrectPinState();
        }
        else
        {
            Console.WriteLine("You entered the wrong PIN");
            _atmMachine.SetNoCardState();
        }
    }

    public void RequestCash(int cashToWithdraw)
    {
        Console.WriteLine("You have not entered your PIN");
    }
}

