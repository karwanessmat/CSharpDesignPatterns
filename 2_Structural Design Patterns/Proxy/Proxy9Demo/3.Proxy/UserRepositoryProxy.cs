// Proxy class

using Proxy9Demo._1.Subject_Interface;
using Proxy9Demo._2.RealSubject;

namespace Proxy9Demo._3.Proxy;

public class UserRepositoryProxy(string userRole) : IUserRepository
{
    private readonly UserRepository _userRepository = new();

    public string GetData()
    {
        if (userRole != "Admin")
        {
            Console.WriteLine("Access denied. User must be admin.");
            return string.Empty;
        }

        Console.WriteLine("User verified as admin. Access granted.");
        // Access the real subject
        var data = _userRepository.GetData();
        // Log the action
        Console.WriteLine("Data retrieved: " + data);
        return data;
    }
}