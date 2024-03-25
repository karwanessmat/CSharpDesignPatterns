using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator3Demo
{
  public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(string name, int id)
        {
            Name = name;
            Id = id;
        }
    }
}
