using System;
using Proxy6Demo._1._Subject_Interface;
using Proxy6Demo._2.RealSubject;

namespace Proxy6Demo._3.Proxy
{

    /// <summary>
    /// Proxy class
    /// </summary>
    internal class SharedFolderProxy(Employee emp) : ISharedFolder
    {
        private ISharedFolder _folder;

        public void PerformReadWriteOperations()
        {
            if (emp.Role.ToUpper() == "CEO" || emp.Role.ToUpper() == "MANAGER")
            {
                _folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformReadWriteOperations method'");
                _folder.PerformReadWriteOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
