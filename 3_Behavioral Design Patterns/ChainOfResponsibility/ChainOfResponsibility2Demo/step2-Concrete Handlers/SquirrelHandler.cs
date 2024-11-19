using ChainOfResponsibility2Demo.Step1_Interface;

namespace ChainOfResponsibility2Demo.step2_Concrete_Handlers;

// Squirrel سمۆره‌
internal class SquirrelHandler : AbstractHandler
{
    public override object Handle(object request)
    {

        //if (request.ToString() == "Nut")
        //{
        //    return $"Squirrel: I'll eat the {request.ToString()}.\n";
        //}
        //else
        //{
        //    return base.Handle(request);
        //}

        return request.ToString() == "Nut" 
            ? $"Squirrel: I'll eat the {request}.\n" 
            : base.Handle(request);
    }
}