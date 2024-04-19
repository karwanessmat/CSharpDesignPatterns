// Example of using a proxy

using Proxy9Demo._1.Subject_Interface;
using Proxy9Demo._2.RealSubject;
using Proxy9Demo._3.Proxy;

IUserRepository userRepository = new UserRepositoryProxy("User");
Console.WriteLine(userRepository.GetData());

// Switching to Admin role
userRepository = new UserRepositoryProxy("Admin");
Console.WriteLine(userRepository.GetData());

// Direct access without proxy
userRepository = new UserRepository();
Console.WriteLine("Direct access: " + userRepository.GetData());




/*

When Using a Proxy:
   What Happens: The proxy checks the user's role. If the user is an admin, it proceeds; otherwise, it denies access.
   Where and How: The check is performed in the GetData method of the UserRepositoryProxy. The proxy logs who accessed the data and the content accessed.
   What We Get: Enhanced security and logging of data access.


Without a Proxy:
   Risks and Problems:
   Security: Direct access without checks can expose sensitive data to unauthorized users.
   Lack of Logging: Without a proxy, the application would not log who accessed the data, which is crucial for auditing and monitoring.
   Resource Management: If the object were resource-intensive, directly creating and using it without checks could lead to inefficient resource usage.


In summary, using a proxy provides a controlled way of accessing sensitive or resource-intensive objects, adding security measures and logging, 
and managing resources effectively. Without it, your application could be at risk of security breaches, unauthorized data access, and inefficient resource use.
   
   
   
   
   
   
   
 */
