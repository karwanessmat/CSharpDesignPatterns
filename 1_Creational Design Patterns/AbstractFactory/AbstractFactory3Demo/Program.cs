using System;
using AbstractFactory3Demo.Step3_Abstract_Factory;
using AbstractFactory3Demo.Step4_Concrete_Factories;
using AbstractFactory3Demo.Step5_Client;

namespace AbstractFactory3Demo;

internal class Program
{
    private static void Main()
    {

        IComputerFactory employeeSystemFactory = new EmployeeSystemFactory().Create(2, "win.dev");
        var employeeSystemManage = new EmployeeSystemManager(employeeSystemFactory);
        string getDetails= employeeSystemManage.GetSystemDetails();
        Console.WriteLine(getDetails);


        Console.ReadLine();
    }
}