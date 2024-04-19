using System;
using Adapter5Demo.Step1___Interface;
using Adapter5Demo.step2_Adapter_Class;

namespace Adapter5Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new EmployeeAdapter();
            var client = new ThirdPartyBillingSystem(target);
            client.ShowEmployeeList();
            Console.ReadKey();
        }
    }
}
