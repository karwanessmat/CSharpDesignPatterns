using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter5Demo
{
    /// <summary>
    /// The 'Client' class
    /// </summary>
    public class ThirdPartyBillingSystem
    {
        private readonly ITarget _employeeSource;

        public ThirdPartyBillingSystem(ITarget employeeSource)
        {
            this._employeeSource = employeeSource;
        }

        public void ShowEmployeeList()
        {
            var employee = _employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }
}
