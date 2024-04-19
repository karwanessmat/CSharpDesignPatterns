namespace State3Demo._1_CreateStateInterface;

public interface IAtmState
{
    public void InsertCard();
    public void EjectCard();
    public void InsertPin(int pin);
    public void RequestCash(int cashToWithdraw);
}