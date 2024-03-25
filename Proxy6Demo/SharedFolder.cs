using System;

namespace Proxy6Demo
{

    /// <summary>
    /// real object
    /// </summary>
    public class SharedFolder : ISharedFolder
    {
        public void PerformRwOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
