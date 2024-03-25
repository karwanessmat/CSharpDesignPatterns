namespace ChainOfResponsibility3Demo
{
    //---------------- handler Base class ----------------------
    public abstract class HandlerBase
    {
        public HandlerBase NextTeam { get; private set; }
        public ContextObject Question { get; private set; }

        protected HandlerBase(HandlerBase nextHandler, ContextObject question)
        {
            NextTeam = nextHandler;
            Question = question;
        }

        public abstract void HandleRequest();
    }


    public class ContextObject
    {
        public string Question { get; set; }
    }
}
