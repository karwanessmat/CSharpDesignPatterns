using State3Demo._1_CreateStateInterface;
using State3Demo._2_ImplementConcreteStates;

namespace State3Demo._3_ContextClass;

public class AtmMachine
{
    private readonly IAtmState _hasCard;
    private readonly IAtmState _noCard;
    private readonly IAtmState _correctPin;
    private readonly IAtmState _noCash;

    private IAtmState _atmState;
    public int CashInMachine = 2000;

    public AtmMachine()
    {
        _hasCard = new HasCardState(this);
        _noCard = new NoCardState(this);
        _correctPin = new CorrectPinState(this);
        _noCash = new NoCashState(this);

        _atmState = _noCard;

        if (CashInMachine > 0)
        {
            _atmState = _noCard;
        }
    }

    public void SetAtmState(IAtmState newAtmState)
    {
        _atmState = newAtmState;
    }

    public void SetNoCardState()
    {
        _atmState = _noCard;
    }

    public void SetHasCardState()
    {
        _atmState = _hasCard;
    }

    public void SetCorrectPinState()
    {
        _atmState = _correctPin;
    }

    public void SetNoCashState()
    {
        _atmState = _noCash;
    }

    public void InsertCard()
    {
        _atmState.InsertCard();
    }

    public void EjectCard()
    {
        _atmState.EjectCard();
    }

    public void InsertPin(int pin)
    {
        _atmState.InsertPin(pin);
    }

    public void RequestCash(int cashToWithdraw)
    {
        _atmState.RequestCash(cashToWithdraw);
    }
}
