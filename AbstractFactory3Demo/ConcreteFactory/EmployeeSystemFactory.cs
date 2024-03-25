using AbstractFactory3Demo.Enums;

namespace AbstractFactory3Demo.ConcreteFactory
{
    internal class EmployeeSystemFactory
    {
       public IComputerFactory Create(int employeeId,string position)
        {
            IComputerFactory returnValue;
            if (employeeId==1)
            {
                returnValue = position=="ios.dev" ? new AppleDesktopFactory() : new AppleLaptopFactory();
            }
            else
            {
                returnValue = position == "uwp.dev" ? new DellDesktopFactory() : new DellLaptopFactory();

            }

            return returnValue;

        }

    }
}
