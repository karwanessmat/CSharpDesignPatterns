﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter5Demo
{
    /// <summary>
    /// The 'Adaptee' class
    /// </summary>
    public class HrSystem
    {
        public string[][] GetEmployees()
        {
            var employees = new string[4][];

            employees[0] = new string[] { "100", "Deepak", "Team Leader" };
            employees[1] = new string[] { "101", "Rohit", "Developer" };
            employees[2] = new string[] { "102", "Gautam", "Developer" };
            employees[3] = new string[] { "103", "Dev", "Tester" };

            return employees;
        }
    }
}
