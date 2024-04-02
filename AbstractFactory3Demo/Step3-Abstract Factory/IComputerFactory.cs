using AbstractFactory3Demo.Step1_Abstract_Product;

namespace AbstractFactory3Demo.Step3_Abstract_Factory
{
    internal interface IComputerFactory
    {
        IBrand Brand();
        IComputerType ComputerTypes();
        IProcessor Processor();
    }
}
