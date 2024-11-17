using System;
using System.Collections.Generic;
using Adapter5Demo.Step1___Interface;

namespace Adapter5Demo;

/// <summary>
/// The 'Client' class
/// </summary>
public class ThirdPartyBillingSystem(ITarget employeeSource)
{
    public void ShowEmployeeList()
    {
        List<string> employee = employeeSource.GetEmployeeList();
        //To DO: Implement you business logic

        Console.WriteLine("######### Employee List ##########");
        foreach (string item in employee)
        {
            Console.Write(item);
        }
    }
}