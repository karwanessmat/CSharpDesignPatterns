using AbstractFactory3Demo.Step3_Abstract_Factory;

namespace AbstractFactory3Demo.Step5_Client;

internal class EmployeeSystemManager(IComputerFactory computerFactory)
{
    public string GetSystemDetails()
    {
        var brand = computerFactory.Brand();
        var processor = computerFactory.Processor();
        var computerType = computerFactory.ComputerTypes();


        return $"{brand.GetBrand()} {processor.GetProcessor()} {computerType.GetComputerTypes()}";
    }
}