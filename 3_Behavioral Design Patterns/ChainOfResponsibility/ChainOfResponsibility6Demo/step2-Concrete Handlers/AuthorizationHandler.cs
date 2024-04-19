using ChainOfResponsibility6Demo.Step1_Interface;

namespace ChainOfResponsibility6Demo.step2_Concrete_Handlers;

internal class AuthorizationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Role != "Admin")
            return new Response(false, "User not authorized.");

        if (Successor is not null)
            return Successor.HandleRequest(request);

        return new Response(true, "Authorization successful.");
    }
}