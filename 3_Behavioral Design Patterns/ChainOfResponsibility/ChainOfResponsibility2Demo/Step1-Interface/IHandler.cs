namespace ChainOfResponsibility2Demo.Step1_Interface;

// The Handler interface declares a method for building the chain of
// handlers. It also declares a method for executing a request.
public interface IHandler
{
    IHandler SetNext(IHandler handler);
    object Handle(object request);
}