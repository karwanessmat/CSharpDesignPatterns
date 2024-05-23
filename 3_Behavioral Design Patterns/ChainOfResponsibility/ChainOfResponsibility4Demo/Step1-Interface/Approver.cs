namespace ChainOfResponsibility4Demo.Step1_Interface;

/// <summary>
/// The 'Handler' abstract class
/// </summary>
public abstract class Approver(Approver successor)
{
    protected Approver Successor = successor;


    public abstract void ProcessRequest(Purchase purchase);
}