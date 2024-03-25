using System;
using System.Collections.Generic;
using System.Text;
using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.Client
{
    internal class EmployeeSystemManager
  {
      private readonly IComputerFactory _computerFactory;

      public EmployeeSystemManager(IComputerFactory computerFactory)
      {
          _computerFactory = computerFactory;
      }

      public string GetSystemDetails()
      {
          var brand = _computerFactory.Brand();
          var processor = _computerFactory.Processor();
          var computerType = _computerFactory.ComputerTypes();


          return $"{brand.GetBrand()} {processor.GetProcessor()} {computerType.GetComputerTypes()}";
      }
  }
}
