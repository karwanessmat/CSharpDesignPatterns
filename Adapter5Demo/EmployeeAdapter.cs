using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter5Demo
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    public class EmployeeAdapter :  ITarget
    {

        private readonly HrSystem _hrSystem;

        public EmployeeAdapter()
        {
            _hrSystem= new HrSystem();
        }
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
