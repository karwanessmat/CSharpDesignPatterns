using System;

namespace Proxy6Demo
{

    /// <summary>
    /// Proxy class
    /// </summary>
    internal class SharedFolderProxy : ISharedFolder
    {
        private ISharedFolder _folder;
        private readonly Employee _employee;
        public SharedFolderProxy(Employee emp)
        {
            _employee = emp;
        }
        public void PerformRwOperations()
        {
            if (_employee.Role.ToUpper() == "CEO" || _employee.Role.ToUpper() == "MANAGER")
            {
                _folder = new SharedFolder();
                Console.WriteLine("Shared Folder Proxy makes call to the RealFolder 'PerformRWOperations method'");
                _folder.PerformRwOperations();
            }
            else
            {
                Console.WriteLine("Shared Folder proxy says 'You don't have permission to access this folder'");
            }
        }
    }
}
