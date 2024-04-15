using AbstractFactory3Demo.Step3_Abstract_Factory;

namespace AbstractFactory3Demo.Step4_Concrete_Factories
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
                returnValue = position == "win.dev" ? new DellDesktopFactory() : new DellLaptopFactory();

            }

            return returnValue;

        }

    }
}
