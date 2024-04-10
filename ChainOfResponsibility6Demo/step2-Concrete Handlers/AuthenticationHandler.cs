using ChainOfResponsibility6Demo.Step1_Interface;

namespace ChainOfResponsibility6Demo.step2_Concrete_Handlers;

internal class AuthenticationHandler : RequestHandler
{
    public override Response HandleRequest(Request request)
    {
        if (request.Username != "John" ||
            request.Password != "password")
            return new Response(false, "Invalid username or password.");

        if (Successor is not null)
            // Successor is an instance that we set in main program (var handler2 = new AuthorizationHandler();)
            // then we call var response1 = handler1.HandleRequest(request1);
            return Successor.HandleRequest(request);

        return new Response(true, "Authentication successful.");
    }
}