using System;
using AbstractFactory3Demo.Client;
using AbstractFactory3Demo.ConcreteFactory;

namespace AbstractFactory3Demo
{
    internal class Program
    {
        private static void Main()
        {

            var employeeSystemFactory = new EmployeeSystemFactory().Create(2, "uwp.dev");
            var employeeSystemManage = new EmployeeSystemManager(employeeSystemFactory);
           var getDetails= employeeSystemManage.GetSystemDetails();
           Console.WriteLine(getDetails);


           Console.ReadLine();
        }
    }
}
