namespace Facade5Demo.Services
{
    public class ServiceFacade : IServiceFacade
    {
        private readonly ServiceA _serviceA = new();
        private readonly ServiceB _serviceB = new();
        private readonly ServiceC _serviceC = new();
        
        public Tuple<int, double, string> CallFacade()
        {
            var saResult = _serviceA.Method2();
            var sbResult = _serviceB.Method2();
            var scResult = _serviceC.Method1();
            
            return new Tuple<int, double, string>(saResult, scResult, sbResult);
        }
    }
}