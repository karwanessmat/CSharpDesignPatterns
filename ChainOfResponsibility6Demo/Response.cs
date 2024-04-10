namespace ChainOfResponsibility6Demo;

internal class Response(bool success, string message)
{
    public bool Success { get; } = success;
    public string? Message { get; } = message;
}