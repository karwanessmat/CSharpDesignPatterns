using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter5Demo
{
    /// <summary>
    /// The 'ITarget' interface
    /// </summary>
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}
