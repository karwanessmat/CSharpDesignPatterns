namespace Proxy6Demo;

public class Employee(string username, string password, string role)
{
    public string Username { get; set; } = username;
    public string Password { get; set; } = password;
    public string Role { get; set; } = role;
}