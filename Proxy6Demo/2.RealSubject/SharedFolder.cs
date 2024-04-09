using System;
using Proxy6Demo._1._Subject_Interface;

namespace Proxy6Demo._2.RealSubject
{

    /// <summary>
    /// real object
    /// </summary>
    public class SharedFolder : ISharedFolder
    {
        public void PerformReadWriteOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        }
    }
}
