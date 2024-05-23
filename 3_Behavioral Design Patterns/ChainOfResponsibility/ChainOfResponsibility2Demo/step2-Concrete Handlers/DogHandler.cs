using ChainOfResponsibility2Demo.Step1_Interface;

namespace ChainOfResponsibility2Demo;

internal class DogHandler : AbstractHandler
{
    public override object Handle(object request)
    {
        //if (request.ToString() == "MeatBall")
        //{
        //    return $"Dog: I'll eat the {request.ToString()}.\n";
        //}
        //else
        //{
        //    return base.Handle(request);
        //}
        return request.ToString() == "MeatBall"
            ? $"Dog: I'll eat the {request}.\n" 
            : base.Handle(request);
    }
}