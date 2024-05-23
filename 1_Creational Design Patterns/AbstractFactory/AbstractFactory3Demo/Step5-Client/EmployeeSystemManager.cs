using AbstractFactory3Demo.Step1_Abstract_Products;
using AbstractFactory3Demo.Step3_Abstract_Factory;

namespace AbstractFactory3Demo.Step5_Client;

internal class EmployeeSystemManager(IComputerFactory computerFactory)
{
    public string GetSystemDetails()
    {
        IBrand brand = computerFactory.Brand();
        IProcessor processor = computerFactory.Processor();
        IComputerType computerType = computerFactory.ComputerTypes();


        return $"{brand.GetBrand()} {processor.GetProcessor()} {computerType.GetComputerTypes()}";
    }
}