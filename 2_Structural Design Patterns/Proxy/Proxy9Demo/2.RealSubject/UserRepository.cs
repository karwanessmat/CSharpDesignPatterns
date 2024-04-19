// RealSubject class

using Proxy9Demo._1.Subject_Interface;

namespace Proxy9Demo._2.RealSubject;

public class UserRepository : IUserRepository
{
    public string GetData()
    {
        // Simulate fetching sensitive data
        return "Sensitive user data";
    }
}