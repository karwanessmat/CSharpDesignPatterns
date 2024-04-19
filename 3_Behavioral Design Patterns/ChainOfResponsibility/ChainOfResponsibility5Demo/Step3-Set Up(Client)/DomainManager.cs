using ChainOfResponsibility5Demo.Step1_Interface;

namespace ChainOfResponsibility5Demo.Step3_Set_Up_Client_;

public class DomainManager(Handler handler)
{
    // handler was instead when we call Domain Manager so that we removed private Handler _handler = handler
    //private Handler _handler = handler

    public void ProcessDomainRegistration(DomainRequest request)
    {
        handler.Handle(request);

    }
}