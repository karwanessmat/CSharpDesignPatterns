namespace ChainOfResponsibility6Demo.Step1_Interface;

internal abstract class RequestHandler
{
    protected RequestHandler? Successor;

    public abstract Response HandleRequest(Request request);

    // use just use to set not using in derived classes
    public void SetNext(RequestHandler successor)
    {
        Successor = successor;
    }
}


//public abstract class Approver(Approver successor)
//{
//    protected Approver Successor = successor;
//    public abstract void HandleRequest(Approver purchase);
//}