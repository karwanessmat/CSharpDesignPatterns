using System;
using Adapter5Demo.Step1___Interface;

namespace Adapter5Demo;

/// <summary>
/// The 'Client' class
/// </summary>
public class ThirdPartyBillingSystem(ITarget employeeSource)
{
    public void ShowEmployeeList()
    {
        var employee = employeeSource.GetEmployeeList();
        //To DO: Implement you business logic

        Console.WriteLine("######### Employee List ##########");
        foreach (var item in employee)
        {
            Console.Write(item);
        }

    }
}