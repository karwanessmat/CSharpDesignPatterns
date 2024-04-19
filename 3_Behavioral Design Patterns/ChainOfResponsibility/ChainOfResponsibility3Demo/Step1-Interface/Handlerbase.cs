namespace ChainOfResponsibility3Demo.Step1_Interface
{
    //---------------- handler Base class ----------------------
    public abstract class HandlerBase(HandlerBase nextHandler, ContextObject question)
    {
        public HandlerBase NextTeam { get; private set; } = nextHandler;
        public ContextObject Question { get; private set; } = question;

        public abstract void HandleRequest();
    }
}
