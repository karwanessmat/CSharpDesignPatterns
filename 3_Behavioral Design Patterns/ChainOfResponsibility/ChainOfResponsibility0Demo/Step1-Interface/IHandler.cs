namespace ChainOfResponsibility0Demo.Step1_Interface
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        void HandleRequest(string request);
    }
}
