using ChainOfResponsibility2Demo.Step1_Interface;

namespace ChainOfResponsibility2Demo
{
    class MonkeyHandler : AbstractHandler
    {
        public override object Handle(object request)
        {
            //if ((request as string) == "Banana")
            //{
            //    return $"Monkey: I'll eat the {request.ToString()}.\n";
            //}
            //else
            //{
            //    return base.Handle(request);
            //}
            return (request as string) == "Banana"
                ? $"Monkey: I'll eat the {request}.\n" 
                : base.Handle(request);
        }
    }
}
