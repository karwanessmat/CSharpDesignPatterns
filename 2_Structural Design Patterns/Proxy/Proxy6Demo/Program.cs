using System;
using Proxy6Demo._3.Proxy;

namespace Proxy6Demo;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Client passing employee with Role Developer to folderproxy");
        var emp1 = new Employee("Anurag", "Anurag123", "Developer");
        var folderProxy1 = new SharedFolderProxy(emp1);
        folderProxy1.PerformReadWriteOperations();

        Console.WriteLine();

        Console.WriteLine("Client passing employee with Role Manager to folderproxy");
        var emp2 = new Employee("Pranaya", "Pranaya123", "Manager");
        var folderProxy2 = new SharedFolderProxy(emp2);
        folderProxy2.PerformReadWriteOperations();
        Console.Read();
    }
}