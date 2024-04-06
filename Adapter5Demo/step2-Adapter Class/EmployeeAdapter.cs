using System.Collections.Generic;
using Adapter5Demo.Step1___Interface;
using Adapter5Demo.Step3_Client___Adaptee;

namespace Adapter5Demo.step2_Adapter_Class
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class EmployeeAdapter :  ITarget
    {

        private readonly HrSystem _hrSystem = new();

        public List<string> GetEmployeeList()
        {
            var employeeList = new List<string>();
            var employees = _hrSystem.GetEmployees();
           
            foreach (var employee in employees)
            {
                employeeList.Add(employee[0]);
                employeeList.Add(",");
                employeeList.Add(employee[1]);
                employeeList.Add(",");
                employeeList.Add(employee[2]);
                employeeList.Add("\n");
            }

            return employeeList;
        }
    }
}
