using Facade5Demo.Subsystem_Classes;

namespace Facade5Demo;

public class ServiceFacade : IServiceFacade
{
    private readonly ServiceA _serviceA = new();
    private readonly ServiceB _serviceB = new();
    private readonly ServiceC _serviceC = new();

    public Tuple<int, double, string> CallFacade()
    {
        int aResult = _serviceA.Method2();
        string? bResult = _serviceB.Method2();
        double cResult = _serviceC.Method1();

        return new Tuple<int, double, string>(aResult, cResult, bResult);
    }
}