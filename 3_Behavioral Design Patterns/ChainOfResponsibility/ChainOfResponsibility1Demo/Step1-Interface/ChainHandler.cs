namespace ChainOfResponsibility1Demo.Step1_Interface;

public abstract  class ChainHandler
{
    public ChainHandler Successor;
    public void SetSuccessor(ChainHandler successor)
    {
        Successor = successor;
    }
    public abstract void HandlerRequest(int request);
}